using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RecyclerofMatter:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 46;
			Item.height = 46;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.RecyclerofMatterTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Recycler of Matter");
			// Tooltip.SetDefault("Allows to convert hardmode metals to their alternatives");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.TitaniumBar, 1);
			recipe.AddIngredient(ItemID.AdamantiteBar, 1);
			recipe.AddIngredient(ItemID.Glass, 20);
			recipe.AddIngredient(ItemID.LavaBucket, 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
