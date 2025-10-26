using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightmareBrick:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.value = 10000;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = 11;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.NightmareBrickTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightmare Brick");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBrickWall>(), 4);
			recipe.SetResult(this, 1);
			recipe.AddTile(17);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareOre>(), 1);
			recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.SetResult(this, 2);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
