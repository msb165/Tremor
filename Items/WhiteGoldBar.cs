using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class WhiteGoldBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 17500;
			Item.rare = 11;
			Item.createTile = ModContent.TileType<Tiles.WhiteGoldBarTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("White Gold Bar");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Catalyst>(), 1);
			recipe.AddIngredient(ItemID.PlatinumOre, 3);
			recipe.AddIngredient(ItemID.GoldOre, 3);
			recipe.SetResult(this, 2);
			recipe.AddTile(ModContent.TileType<Tiles.DivineForgeTile>());
			recipe.AddRecipe();
		}
	}
}
