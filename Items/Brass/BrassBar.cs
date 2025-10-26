using Terraria.ModLoader;

namespace Tremor.Items.Brass
{
	public class BrassBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 300;
			Item.rare = 5;
			Item.createTile = ModContent.TileType<Tiles.BrassBar>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Bar");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BrassNugget>(), 2);
			recipe.AddIngredient(ModContent.ItemType<Charcoal>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.BlastFurnace>());
			recipe.AddRecipe();
		}
	}
}
