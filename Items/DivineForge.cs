using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Angelite;

namespace Tremor.Items
{
	public class DivineForge:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 50;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.rare = 11;
			item.autoReuse = true;
			item.useAnimation = 15;

			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = ModContent.TileType<Tiles.DivineForgeTile>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Divine Forge");
			Tooltip.SetDefault("Combines the function of the anvil, furnace and the ancient manipulator\n" +
"Allows you to work with heavenly materials");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CollapsiumOre>(), 30);
			recipe.AddIngredient(ModContent.ItemType<AngeliteOre>(), 30);
			recipe.AddIngredient(ModContent.ItemType<OmnikronBar>(), 5);
			recipe.AddIngredient(ItemID.MythrilAnvil, 1);
			recipe.AddIngredient(ItemID.AdamantiteForge, 1);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 10);
			recipe.AddIngredient(3549, 1);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CollapsiumOre>(), 30);
			recipe.AddIngredient(ModContent.ItemType<AngeliteOre>(), 30);
			recipe.AddIngredient(ModContent.ItemType<OmnikronBar>(), 5);
			recipe.AddIngredient(ItemID.OrichalcumAnvil, 1);
			recipe.AddIngredient(ItemID.AdamantiteForge, 1);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 10);
			recipe.AddIngredient(3549, 1);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CollapsiumOre>(), 30);
			recipe.AddIngredient(ModContent.ItemType<AngeliteOre>(), 30);
			recipe.AddIngredient(ModContent.ItemType<OmnikronBar>(), 5);
			recipe.AddIngredient(ItemID.OrichalcumAnvil, 1);
			recipe.AddIngredient(ItemID.TitaniumForge, 1);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 10);
			recipe.AddIngredient(3549, 1);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CollapsiumOre>(), 30);
			recipe.AddIngredient(ModContent.ItemType<AngeliteOre>(), 30);
			recipe.AddIngredient(ModContent.ItemType<OmnikronBar>(), 5);
			recipe.AddIngredient(ItemID.MythrilAnvil, 1);
			recipe.AddIngredient(ItemID.TitaniumForge, 1);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 10);
			recipe.AddIngredient(3549, 1);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
