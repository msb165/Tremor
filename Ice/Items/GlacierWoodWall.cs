using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class GlacierWoodWall:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 7;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createWall = ModContent.WallType<GlacierWoodWallWall>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood Wall");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(null, nameof(GlacierWood), 1);
			recipe.SetResult(this, 4);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
