using Terraria.ModLoader;

namespace Tremor.Ice.Items.Furniture
{
	public class IcePiano:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glacier Wood Piano");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 2000;
			item.createTile = ModContent.TileType<IcePianoTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(154, 4);
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 15);
			recipe.AddIngredient(149);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}