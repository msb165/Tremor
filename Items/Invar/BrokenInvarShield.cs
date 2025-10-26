using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Invar
{
	public class BrokenInvarShield:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 30;
			Item.maxStack = 990;
			Item.value = Item.sellPrice(silver: 2);
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Broken Invar Shield");
			// Tooltip.SetDefault("Broken and useless... But its materials could be reused");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(this);
			recipe.SetResult(ModContent.ItemType<InvarBar>(), 2);
			recipe.AddTile(TileID.Furnaces);
			recipe.AddRecipe();
		}
	}
}
