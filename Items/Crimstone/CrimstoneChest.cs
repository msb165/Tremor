using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Crimstone
{
	public class CrimstoneChest:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 18;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<Tiles.CrimstoneChest>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crimstone Chest");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(836, 8);
			recipe.AddIngredient(1257, 1);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(836, 8);
			recipe.AddIngredient(1257, 1);
			recipe.AddIngredient(ItemID.LeadBar, 2);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
