using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Tiles;

namespace Tremor.ZombieEvent.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class SpecterHood:TremorModItem
	{
		const int ShootType = ProjectileID.HeatRay; 
		const float ShootRange = 600.0f; 
		const float ShootKN = 1.0f; 
		const int ShootRate = 120; 
		const int ShootCount = 2; 
		const float ShootSpeed = 20f; 
		const int spread = 45; 
		const float spreadMult = 0.045f; 

		int TimeToShoot = ShootRate;

		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 22;

			Item.value = 10000;
			Item.rare = 11;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Specter Hood");
			/* Tooltip.SetDefault("10% increased melee damage\n" +
			                   "10% increased minion damage"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.1f;
			player.GetDamage(DamageClass.Summon) += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<SpecterChestplate>() && legs.type == ModContent.ItemType<SpecterPants>();
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadow = true;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Summons the cursed skulls to fight for you.";

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
				if (Main.npc[k].active && Main.npc[k].lifeMax > 5 && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].Distance(Main.player[Item.playerIndexTheItemIsReservedFor].Center) <= ShootRange && Collision.CanHitLine(Main.player[Item.playerIndexTheItemIsReservedFor].Center, 4, 4, Main.npc[k].Center, 4, 4))
				{
					Target = k;
					break;
				}
			}
			return Target;
		}

		int GetDamage()
		{
			return Main.player[Item.playerIndexTheItemIsReservedFor].GetSpecialProjectileDamage(6, 15);
		}

		void Shoot(int Target, int Damage)
		{
			Vector2 velocity = Helper.VelocityToPoint(Main.player[Item.playerIndexTheItemIsReservedFor].Center, Main.npc[Target].Center, ShootSpeed);
			for (int l = 0; l < ShootCount; l++)
			{
				velocity.X = velocity.X + Main.rand.Next(-spread, spread + 1) * spreadMult;
				velocity.Y = velocity.Y + Main.rand.Next(-spread, spread + 1) * spreadMult;
				int i = Projectile.NewProjectile(null, Main.player[Item.playerIndexTheItemIsReservedFor].Center.X, Main.player[Item.playerIndexTheItemIsReservedFor].Center.Y, velocity.X, velocity.Y, 270, 100, ShootKN, Item.playerIndexTheItemIsReservedFor);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CryptStone>(), 3);
			recipe.AddIngredient(ModContent.ItemType<CursedCloth>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
