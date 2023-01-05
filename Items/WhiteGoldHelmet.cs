using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class WhiteGoldHelmet:TremorModItem
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

			item.width = 38;
			item.height = 22;

			item.value = 10000;
			item.rare = 11;
			item.defense = 30;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Gold Helmet");
			Tooltip.SetDefault("20% increased ranged damage\n" +
"20% increased melee damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Ranged) += 0.2f;
			player.GetDamage(DamageClass.Melee) += 0.2f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<WhiteGoldBreastplate>() && legs.type == ModContent.ItemType<WhiteGoldGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Shoots dangerous gold daggers";

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
				int i = Projectile.NewProjectile(null, Main.player[item.playerIndexTheItemIsReservedFor].Center.X, Main.player[item.playerIndexTheItemIsReservedFor].Center.Y, velocity.X, velocity.Y, ModContent.ProjectileType<Projectiles.WhiteGoldKnife>(), 100, ShootKN, item.playerIndexTheItemIsReservedFor);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<WhiteGoldBar>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.DivineForgeTile>());
			recipe.AddRecipe();
		}
	}
}
