using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EbonstoneGrandfatherClock:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 74;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<Tiles.EbonstoneGrandfatherClock>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ebonstone Grandfather Clock");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(61, 10);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddIngredient(ItemID.Glass, 6);
			recipe.AddIngredient(57, 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(61, 10);
			recipe.AddIngredient(ItemID.LeadBar, 3);
			recipe.AddIngredient(ItemID.Glass, 6);
			recipe.AddIngredient(57, 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}

	}
}
