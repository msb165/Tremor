using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class Permafrost:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 123;
			Item.DamageType = DamageClass.Melee;
			Item.width = 38;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 34;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 160000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = 263;
			Item.shootSpeed = 10f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Permafrost");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 1, speedY - 1, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FrostoneBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<IceSoul>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
