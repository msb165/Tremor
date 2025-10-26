using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StarSmithy:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 46;
			Item.height = 46;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.StarvilTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Starvil");
			// Tooltip.SetDefault("Allows you to treat space materials");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MeteoriteBar, 15);
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Squorb>(), 3);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MeteoriteBar, 15);
			recipe.AddIngredient(ItemID.PlatinumBar, 15);
			recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Squorb>(), 3);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
