using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class StarlightGlimmer:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.autoReuse = true;
			Item.useStyle = 5;
			Item.useAnimation = 12;
			Item.useTime = 12;

			Item.width = 50;
			Item.height = 18;
			Item.shoot = 12;
			Item.useAmmo = AmmoID.FallenStar;
			Item.UseSound = SoundID.Item9;
			Item.damage = 228;
			Item.shootSpeed = 14f;
			Item.noMelee = true;
			Item.value = 1000000;
			Item.rare = 2;

			Item.DamageType = DamageClass.Ranged;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Starlight Glimmer");
			// Tooltip.SetDefault("Shoots fallen stars");
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
			recipe.AddIngredient(ItemID.StarCannon, 1);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 16);
			recipe.AddIngredient(3467, 20);
			recipe.AddIngredient(ItemID.MeteoriteBar, 20);
			recipe.AddIngredient(ItemID.FallenStar, 25);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 28);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
