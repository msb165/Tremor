using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Magmonium
{
	public class MagmoniumBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 10000;
			Item.rare = 8;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.createTile = ModContent.TileType<Tiles.MagmoniumBar>();
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magmonium Bar");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.HellstoneBar, 1);
			recipe.AddIngredient(ItemID.Ectoplasm, 2);
			recipe.SetResult(this);
			recipe.AddTile(133);
			recipe.AddRecipe();
		}
	}
}
