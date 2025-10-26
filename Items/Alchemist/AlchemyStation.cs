using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Alchemist
{
	public class AlchemyStation:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 50;
			Item.height = 26;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;

			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.AlchemyStationTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Alchemy Station");
			// Tooltip.SetDefault("Allows you to create unusual potions and transformation of different materials");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddIngredient(ModContent.ItemType<CarbonSteel>(), 12);
			recipe.AddIngredient(ItemID.SoulofLight, 12);
			recipe.AddIngredient(ItemID.SoulofNight, 12);
			recipe.AddIngredient(ItemID.Glass, 12);
			recipe.AddIngredient(ItemID.Bottle, 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
