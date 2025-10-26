using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EbonstoneChair:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 16;
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
			Item.createTile = ModContent.TileType<Tiles.EbonstoneChair>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ebonstone Chair");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(61, 4);
			recipe.AddIngredient(57, 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
