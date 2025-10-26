using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Flesh
{
	public class FleshWorkstation:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 200;
			Item.createTile = ModContent.TileType<Tiles.FleshWorkstationTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flesh Workstation");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddIngredient(ModContent.ItemType<UntreatedFlesh>(), 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
