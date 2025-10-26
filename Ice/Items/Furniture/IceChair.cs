using Terraria.ModLoader;

namespace Tremor.Ice.Items.Furniture
{
	public class IceChair:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood Chair");
			// Tooltip.SetDefault("");
		}
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
			Item.createTile = ModContent.TileType<IceChairTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}