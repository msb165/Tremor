using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class WickedRing:TremorModItem
	{

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float spread = 45f * 0.0174f;
			double startAngle = Math.Atan2(speedX, speedY) - spread / 2;
			double deltaAngle = spread / 8f;
			double offsetAngle;
			int i;
			for (i = 0; i < 4; i++)
			{
				offsetAngle = (startAngle + deltaAngle * (i + i * i) / 2f) + 32f * i;
				Projectile.NewProjectile(null, position.X, position.Y, (float)(Math.Sin(offsetAngle) * 5f), (float)(Math.Cos(offsetAngle) * 5f), Item.shoot, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(null, position.X, position.Y, (float)(-Math.Sin(offsetAngle) * 5f), (float)(-Math.Cos(offsetAngle) * 5f), Item.shoot, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override void SetDefaults()
		{

			Item.damage = 10;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 30;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.knockBack = 5;
			Item.value = 2500;
			Item.noUseGraphic = true;
			Item.rare = 3;
			Item.UseSound = SoundID.Item21;
			Item.autoReuse = true;
			Item.width = 28;
			Item.height = 30;
			Item.useStyle = 5;

			Item.noMelee = true;
			Item.shoot = 496;
			Item.shootSpeed = 20f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Wicked Ring");
			// Tooltip.SetDefault("Releases shadow tentacles in all directions");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<RupicideBar>(), 3);
			recipe.AddIngredient(ItemID.DemoniteBar, 12);
			recipe.AddIngredient(ItemID.ShadowScale, 12);
			recipe.AddIngredient(ModContent.ItemType<WickedHeart>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.NecromaniacWorkbenchTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<RupicideBar>(), 3);
			recipe.AddIngredient(ItemID.CrimtaneBar, 12);
			recipe.AddIngredient(ItemID.TissueSample, 12);
			recipe.AddIngredient(ModContent.ItemType<WickedHeart>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.NecromaniacWorkbenchTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
