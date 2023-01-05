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

			item.damage = 123;
			item.DamageType = DamageClass.Melee;
			item.width = 38;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 34;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 160000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 263;
			item.shootSpeed = 10f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Permafrost");
			Tooltip.SetDefault("");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<FrostoneBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<IceSoul>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
