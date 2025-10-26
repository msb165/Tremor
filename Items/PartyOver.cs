using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Candy;

namespace Tremor.Items
{
	public class PartyOver:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.useStyle = 5;
			Item.useAnimation = 24;
			Item.useTime = 9;

			Item.width = 24;
			Item.height = 14;
			Item.shoot = 587;
			Item.damage = 122;
			Item.shootSpeed = 10f;
			Item.noMelee = true;
			Item.value = Item.sellPrice(0, 0, 50, 0);
			Item.knockBack = 1.25f;
			Item.scale = 0.85f;
			Item.rare = 2;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 7;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Party Over");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 2, speedY + 2, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 1, speedY - 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 2, speedY - 2, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

		public override Vector2? HoldoutOffset()
		{
			return Vector2.Zero;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 8);
			recipe.AddIngredient(ModContent.ItemType<CandyBar>(), 15);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
