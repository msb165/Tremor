using Terraria.ModLoader;
using Tremor.Items.Crystal;
using Tremor.ZombieEvent.Items;

namespace Tremor.Items.Cursed
{
	public class CursedBanner:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
			Item.height = 64;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;

			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 50000;
			Item.rare = 11;
			Item.createTile = ModContent.TileType<Tiles.CursedBanner>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Banner");
			// Tooltip.SetDefault("Increases all critical strike chance by 25 if placed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<UnstableCrystal>(), 2);
			recipe.AddIngredient(ModContent.ItemType<CursedCloth>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
