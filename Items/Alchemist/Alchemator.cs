using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;

namespace Tremor.Items.Alchemist
{
	public class Alchemator:TremorModItem
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
			Item.rare = 7;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 300000;
			Item.createTile = ModContent.TileType<Tiles.AlchematorTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Alchemator");
			// Tooltip.SetDefault("Allows you to create and use Jellyxir");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.HallowedBar, 1);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
			recipe.AddIngredient(ModContent.ItemType<DarkBulb>(), 10);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 10);
			recipe.AddIngredient(ModContent.ItemType<EssenseofJungle>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 1);
			recipe.AddIngredient(ItemID.Glass, 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
