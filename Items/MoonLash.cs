using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MoonLash:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 259;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 20;
			Item.width = 34;
			Item.height = 30;
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 13800;
			Item.rare = 10;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = false;
			Item.shoot = 645;
			Item.shootSpeed = 12f;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Moon Lash");
			// Tooltip.SetDefault("Erupts three moon flame bolts");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 1, speedY - 1, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ScourgeofFlames>(), 1);
			recipe.AddIngredient(3467, 15);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 11);
			recipe.AddIngredient(ItemID.PlatinumBar, 9);
			recipe.AddIngredient(ItemID.GoldBar, 9);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
