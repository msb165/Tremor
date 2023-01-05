using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class WhiteGoldBar:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 17500;
			item.rare = 11;
			item.createTile = ModContent.TileType<Tiles.WhiteGoldBarTile>();
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Gold Bar");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Catalyst>(), 1);
			recipe.AddIngredient(ItemID.PlatinumOre, 3);
			recipe.AddIngredient(ItemID.GoldOre, 3);
			recipe.SetResult(this, 2);
			recipe.AddTile(ModContent.TileType<Tiles.DivineForgeTile>());
			recipe.AddRecipe();
		}
	}
}
