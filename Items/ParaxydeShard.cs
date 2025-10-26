using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ParaxydeShard:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 14;
			Item.height = 22;
			Item.maxStack = 999;
			Item.rare = 5;
			Item.value = Item.buyPrice(0, 0, 3, 0);
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paraxyde Shard");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.HallowedBar, 1);
			recipe.AddIngredient(ModContent.ItemType<Jellyxir>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}
	}
}
