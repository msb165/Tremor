using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Gloomstone:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.value = 100;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = 3;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.GloomstoneTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gloomstone");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GloomstoneWall>(), 4);
			recipe.SetResult(this, 1);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
