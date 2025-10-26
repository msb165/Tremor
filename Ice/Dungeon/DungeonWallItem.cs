using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Dungeon
{
	public class DungeonWallItem:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 7;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createWall = ModContent.WallType<DungeonWall>();
			ItemID.Sets.ExtractinatorMode[Item.type] = Item.type;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frost Brick Wall");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(null, nameof(DungeonBlockItem));
			recipe.SetResult(this, 4);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
