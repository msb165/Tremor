using Terraria.ModLoader;
using Tremor.Items.Crystal;

namespace Tremor.Items
{
	public class HardCometiteBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 17500;
			Item.rare = 11;
			Item.createTile = ModContent.TileType<Tiles.HardCometiteBarTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hardened Cometite Bar");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<HardCometiteOre>(), 8);
			recipe.AddIngredient(ModContent.ItemType<ChargedCrystal>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
