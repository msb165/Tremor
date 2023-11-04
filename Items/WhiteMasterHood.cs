using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs.Bosses.NovaPillar.Items.Armor;
using Tremor.Projectiles.Alchemic;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class WhiteMasterHood:TremorModItem
	{
		const float ShootRange = 600.0f;
		const float ShootKN = 1.0f;
		const int ShootRate = 120;
		const int ShootCount = 3;
		const float ShootSpeed = 20f;
		const int spread = 45;
		const float spreadMult = 0.045f;
		int TimeToShoot = ShootRate;

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 24;
			item.value = 50000;
			item.rare = 11;
			item.defense = 22;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Master Hood");
			Tooltip.SetDefault("Double tap to dash repeatedly");
		}

		public override void UpdateEquip(Player player)
		{
			//player.GetModPlayer<TremorPlayer>().zellariumHead = true;
			player.dash = 1;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Creates alchemical bubbles to attack enemies\n" +
"Bubbles heal you";
			if (--TimeToShoot <= 0)
			{
				TimeToShoot = ShootRate;
				int Target = GetTarget();
				if (Target != -1)
					Shoot(Target, GetDamage());
			}
		}

		int GetTarget()
		{
			int Target = -1;
			for (int k = 0; k < Main.npc.Length; k++)
			{
				if (Main.npc[k].active && Main.npc[k].lifeMax > 5 && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].Distance(Main.player[item.playerIndexTheItemIsReservedFor].Center) <= ShootRange && Collision.CanHitLine(Main.player[item.playerIndexTheItemIsReservedFor].Center, 4, 4, Main.npc[k].Center, 4, 4))
				{
					Target = k;
					break;
				}
			}
			return Target;
		}

		int GetDamage()
		{
			return Main.player[item.playerIndexTheItemIsReservedFor].GetSpecialProjectileDamage(10, 15);
		}

		void Shoot(int Target, int Damage)
		{
			Vector2 velocity = Helper.VelocityToPoint(Main.player[item.playerIndexTheItemIsReservedFor].Center, Main.npc[Target].Center, ShootSpeed);
			for (int l = 0; l < ShootCount; l++)
			{
				velocity.X = velocity.X + Main.rand.Next(-spread, spread + 1) * spreadMult;
				velocity.Y = velocity.Y + Main.rand.Next(-spread, spread + 1) * spreadMult;
				int i = Projectile.NewProjectile(null, Main.player[item.playerIndexTheItemIsReservedFor].Center.X, Main.player[item.playerIndexTheItemIsReservedFor].Center.Y, velocity.X, velocity.Y, ModContent.ProjectileType<AlchemicBubbleZellarium>(), 115, ShootKN, item.playerIndexTheItemIsReservedFor);
			}
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<WhiteMasterChestplate>() && legs.type == ModContent.ItemType<WhiteMasterGreaves>();
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
			player.armorEffectDrawShadowLokis = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ModContent.ItemType<NovaHelmet>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Aquamarine>(), 4);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 11);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 5);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}