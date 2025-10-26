using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Dungeon
{
	public class DungeonBlockItem:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<DungeonBlock>();
			ItemID.Sets.ExtractinatorMode[Item.type] = Item.type;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frost Brick");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<IceBlockB>(), 2);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DungeonWallItem>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
