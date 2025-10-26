using Terraria.ModLoader;

namespace Tremor.Items.Doom
{
	public class DoombrickWall:TremorModItem
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
			Item.rare = 7;
			Item.consumable = true;
			Item.createWall = ModContent.WallType<Walls.DoombrickWall>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Doombrick Wall");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Doombrick>(), 1);
			recipe.SetResult(this, 4);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
