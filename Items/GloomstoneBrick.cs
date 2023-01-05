using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GloomstoneBrick:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.value = 100;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.rare = 3;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.GloomstoneBrickTile>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gloomstone Brick");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<GloomstoneBrickWall>(), 4);
			recipe.SetResult(this, 1);
			recipe.AddTile(17);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 1);
			recipe.SetResult(this, 1);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
