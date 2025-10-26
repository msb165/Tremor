using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Sandstone
{
	public class SandstoneChandelier:TremorModItem
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
			Item.createTile = ModContent.TileType<Tiles.SandstoneChandelier>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sandstone Chandelier");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(607, 4);
			recipe.AddIngredient(ItemID.Torch, 4);
			recipe.AddIngredient(ItemID.Chain, 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
