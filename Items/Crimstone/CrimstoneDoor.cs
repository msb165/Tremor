using Terraria.ModLoader;

namespace Tremor.Items.Crimstone
{
	public class CrimstoneDoor:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 48;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = ModContent.TileType<Tiles.CrimstoneDoorClosed>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimstone Door");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(836, 6);
			recipe.AddIngredient(1257, 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
