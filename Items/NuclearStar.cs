using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class NuclearStar:TremorModItem
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
				Projectile.NewProjectile(null, position.X, position.Y, (float)(Math.Sin(offsetAngle) * 5f), (float)(Math.Cos(offsetAngle) * 5f), Item.shoot, damage, knockBack, Item.playerIndexTheItemIsReservedFor);
				Projectile.NewProjectile(null, position.X, position.Y, (float)(-Math.Sin(offsetAngle) * 5f), (float)(-Math.Cos(offsetAngle) * 5f), Item.shoot, damage, knockBack, Item.playerIndexTheItemIsReservedFor);
			}
			return false;
		}

		public override void SetDefaults()
		{

			Item.damage = 500;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 50;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.knockBack = 5;
			Item.value = 2500000;
			Item.rare = 9;
			Item.UseSound = SoundID.Item84;
			Item.autoReuse = true;
			Item.width = 28;
			Item.height = 30;
			Item.useStyle = 5;

			Item.noMelee = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.NuclearStarPro>();
			Item.shootSpeed = 20f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nuclear Star");
			// Tooltip.SetDefault("Creates nuclear beams.");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<StarBar>(), 25);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 25);
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(ItemID.Amber, 16);
			recipe.AddIngredient(ModContent.ItemType<Blasticyde>(), 10);
			recipe.AddIngredient(ModContent.ItemType<AngryShard>(), 15);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
