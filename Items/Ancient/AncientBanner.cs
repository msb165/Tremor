using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Crystal;

namespace Tremor.Items.Ancient
{
	public class AncientBanner:TremorModItem
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
			Item.createTile = ModContent.TileType<Tiles.AncientBanner>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ancient Banner");
			// Tooltip.SetDefault("Increases life regeneration if placed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<UnstableCrystal>(), 2);
			recipe.AddIngredient(ItemID.AncientCloth, 25);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
