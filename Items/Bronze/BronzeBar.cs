using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Bronze
{
	public class BronzeBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.BronzeBar>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bronze Bar");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TinOre, 2);
			recipe.AddIngredient(ItemID.CopperOre, 2);
			recipe.AddTile(ModContent.TileType<Tiles.BlastFurnace>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
