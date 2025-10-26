using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Marble
{
	public class MarbleVase:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 22;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.MarbleVase>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Marble Vase");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MarbleBlock, 10);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
