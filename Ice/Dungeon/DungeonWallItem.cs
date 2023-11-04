using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Dungeon
{
	public class DungeonWallItem:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = ModContent.WallType<DungeonWall>();
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frost Brick Wall");
			Tooltip.SetDefault("");
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
