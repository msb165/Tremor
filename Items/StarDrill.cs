using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class StarDrill:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 100;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 5;
			Item.useAnimation = 25;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.pick = 250;
			Item.tileBoost += 8;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 12, 50, 0);
			Item.rare = 0;
			Item.UseSound = SoundID.Item23;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.StarDrillPro>();
			Item.shootSpeed = 40f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Star Drill");
			// Tooltip.SetDefault("");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 3);
			recipe.AddIngredient(ModContent.ItemType<NightCore>(), 3);
			recipe.AddIngredient(ModContent.ItemType<CometiteBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<HardCometiteBar>(), 3);
			recipe.AddIngredient(ModContent.ItemType<StarBar>(), 3);
			recipe.AddIngredient(ModContent.ItemType<LunarRoot>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.AddRecipe();
		}
	}
}
