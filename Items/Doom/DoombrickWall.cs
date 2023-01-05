using Terraria.ModLoader;

namespace Tremor.Items.Doom
{
	public class DoombrickWall:TremorModItem
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
			item.rare = 7;
			item.consumable = true;
			item.createWall = ModContent.WallType<Walls.DoombrickWall>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Doombrick Wall");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Doombrick>(), 1);
			recipe.SetResult(this, 4);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
