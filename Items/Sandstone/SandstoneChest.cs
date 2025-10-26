using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Sandstone
{
	public class SandstoneChest:TremorModItem
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
			Item.createTile = ModContent.TileType<Tiles.SandstoneChest>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sandstone Chest");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(607, 8);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(607, 8);
			recipe.AddIngredient(ItemID.LeadBar, 2);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
