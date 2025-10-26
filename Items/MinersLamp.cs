using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MinersLamp:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<Tiles.MinersLampTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Miners Lamp");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Chain, 1);
			recipe.AddIngredient(ModContent.ItemType<Steel.SteelBar>(), 4);
			recipe.AddIngredient(ModContent.ItemType<Charcoal>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
