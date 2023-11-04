using Terraria.ModLoader;

namespace Tremor.Ice.Items.Furniture
{
	public class IcePlatform:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glacier Wood Platform");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 2000;
			item.createTile = ModContent.TileType<IcePlatformTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 1);
			recipe.SetResult(this, 2);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}