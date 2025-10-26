using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Steel
{
	public class SteelBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 300;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.SteelBar>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Steel Bar");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.AddIngredient(ModContent.ItemType<Charcoal>(), 2);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.BlastFurnace>());
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.LeadBar, 2);
			recipe.AddIngredient(ModContent.ItemType<Charcoal>(), 2);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.BlastFurnace>());
			recipe.AddRecipe();
		}
	}
}
