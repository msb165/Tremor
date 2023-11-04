using Terraria.ModLoader;
using Tremor.Items.Crystal;

namespace Tremor.Items
{
	public class HardCometiteBar:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 17500;
			item.rare = 11;
			item.createTile = ModContent.TileType<Tiles.HardCometiteBarTile>();
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hardened Cometite Bar");
			Tooltip.SetDefault("");
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
