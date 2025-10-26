using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DevilForge:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 50;
			Item.height = 26;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.DevilForge>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Devil Forge");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DemonBlood>(), 5);
			recipe.AddIngredient(ItemID.Hellstone, 25);
			recipe.AddIngredient(ItemID.Obsidian, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
