using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightmareBrickWall:TremorModItem
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
			Item.rare = 11;
			Item.consumable = true;
			Item.createWall = ModContent.WallType<Walls.NightmareBrickWall>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightmare Brick Wall");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBrick>(), 1);
			recipe.SetResult(this, 4);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
