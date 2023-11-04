using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;

namespace Tremor.Items.Alchemist
{
	public class Alchemator:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 50;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;

			item.useAnimation = 15;
			item.useTime = 10;
			item.rare = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 300000;
			item.createTile = ModContent.TileType<Tiles.AlchematorTile>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Alchemator");
			Tooltip.SetDefault("Allows you to create and use Jellyxir");
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
