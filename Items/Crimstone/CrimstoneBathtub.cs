using Terraria.ModLoader;

namespace Tremor.Items.Crimstone
{
	public class CrimstoneBathtub:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 64;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<Tiles.CrimstoneBathtub>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crimstone Bathtub");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(836, 14);
			recipe.AddIngredient(1257, 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
