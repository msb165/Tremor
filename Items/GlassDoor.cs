using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class GlassDoor:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 14;
			Item.height = 28;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.GlassDoorClosed>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glass Door");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddIngredient(ItemID.Glass, 3);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
