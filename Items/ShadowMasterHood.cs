using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class ShadowMasterHood:TremorModItem
	{
		private const float ShootRange = 600.0f;
		private const float ShootKN = 1.0f;
		private const int ShootRate = 120;
		private const int ShootCount = 2;
		private const float ShootSpeed = 20f;
		private const int spread = 45;
		private const float spreadMult = 0.045f;

		private int TimeToShoot = ShootRate;

		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 22;

			item.value = 10000;
			item.rare = 11;
			item.defense = 18;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Master Hood");
			Tooltip.SetDefault("20% increased alchemical damage\n" +
"25% increased throwing damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.20f;
			player.GetDamage(DamageClass.Throwing) += 0.25f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<ShadowMasterChestplate>() && legs.type == ModContent.ItemType<ShadowMasterPants>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Creates dangerous alchemical bubbles\n" +
"35% increased alchemical critical strike chance";
			player.GetModPlayer<MPlayer>().alchemicalCrit += 35;

			if (--TimeToShoot <= 0)
			{
				TimeToShoot = ShootRate;
				int Target = GetTarget();
				if (Target != -1) Shoot(Target, GetDamage());
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
				int i = Projectile.NewProjectile(null, Main.player[item.playerIndexTheItemIsReservedFor].Center.X, Main.player[item.playerIndexTheItemIsReservedFor].Center.Y, velocity.X, velocity.Y, ModContent.ProjectileType<Projectiles.AlchemicBubble>(), 100, ShootKN, item.playerIndexTheItemIsReservedFor);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 10);
			recipe.AddIngredient(ModContent.ItemType<DarkGel>(), 15);
			recipe.AddIngredient(ModContent.ItemType<DarknessCloth>(), 6);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
