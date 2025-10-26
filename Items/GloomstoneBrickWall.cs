using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GloomstoneBrickWall:TremorModItem
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
			Item.rare = 3;
			Item.consumable = true;
			Item.createWall = ModContent.WallType<Walls.GloomstoneBrickWall>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gloomstone Brick Wall");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GloomstoneBrick>(), 1);
			recipe.SetResult(this, 4);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
