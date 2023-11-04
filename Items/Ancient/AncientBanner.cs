using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Crystal;

namespace Tremor.Items.Ancient
{
	public class AncientBanner:TremorModItem
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
			item.createTile = ModContent.TileType<Tiles.AncientBanner>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Banner");
			Tooltip.SetDefault("Increases life regeneration if placed");
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
