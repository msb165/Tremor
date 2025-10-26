using Terraria.ModLoader;

namespace Tremor.Items.Sandstone
{
	public class SandstoneDoor:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 48;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.SandstoneDoorClosed>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sandstone Door");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(607, 6);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
