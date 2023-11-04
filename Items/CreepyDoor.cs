using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CreepyDoor:TremorModItem
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
			item.createTile = ModContent.TileType<Tiles.ScaryDoorClosed>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Creepy Door");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 6);
			recipe.AddIngredient(ItemID.Cobweb, 6);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
