using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Crystal;

namespace Tremor.Items
{
	public class TatteredBanner : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 48;
			item.height = 64;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;

			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 50000;
			item.rare = 11;
			item.createTile = ModContent.TileType<Tiles.TatteredBanner>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tattered Banner");
			Tooltip.SetDefault("25% increased damage if placed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<UnstableCrystal>(), 2);
			recipe.AddIngredient(ItemID.TatteredCloth, 25);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
