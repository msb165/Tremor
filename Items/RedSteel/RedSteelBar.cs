using Terraria.ModLoader;

namespace Tremor.Items.RedSteel
{
	public class RedSteelBar:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 300;
			Item.rare = 1;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.createTile = ModContent.TileType<Tiles.RedSteelBar>();
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Steel Bar");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			//ModRecipe recipe = new ModRecipe();
			//recipe.AddIngredient(ModContent.ItemType<ChippyRedSteelSword>());
			//recipe.SetResult(this, 2);
			//recipe.AddTile(17);
			//recipe.AddRecipe();

			//recipe = new ModRecipe();
			//recipe.AddIngredient(ModContent.ItemType<FaultyRedSteelShield>());
			//recipe.SetResult(this, 3);
			//recipe.AddTile(17);
			//recipe.AddRecipe();

			//recipe = new ModRecipe();
			//recipe.AddIngredient(ModContent.ItemType<RedSteelArmorPiece>());
			//recipe.SetResult(this, 2);
			//recipe.AddTile(17);
			//recipe.AddRecipe();
		}
	}
}
