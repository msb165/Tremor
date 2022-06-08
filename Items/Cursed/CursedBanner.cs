using Terraria.ModLoader;
using Tremor.Items.Crystal;
using Tremor.ZombieEvent.Items;

namespace Tremor.Items.Cursed
{
	public class CursedBanner : ModItem
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
			item.createTile = ModContent.TileType<Tiles.CursedBanner>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Banner");
			Tooltip.SetDefault("Increases all critical strike chance by 25 if placed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<UnstableCrystal>(), 2);
			recipe.AddIngredient(ModContent.ItemType<CursedCloth>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
