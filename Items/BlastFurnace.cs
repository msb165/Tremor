using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BlastFurnace:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 14;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.BlastFurnace>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Blast Furnace");
			// Tooltip.SetDefault("Used to craft alloys");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GrayBrick, 25);
			recipe.AddIngredient(ModContent.ItemType<Charcoal>(), 15);
			recipe.AddIngredient(ItemID.LavaBucket, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
