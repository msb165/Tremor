using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Nano
{
	public class NanoBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 30;

			Item.maxStack = 99;
			Item.value = 10000;
			Item.rare = 6;
			Item.createTile = ModContent.TileType<Tiles.NanoBar>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nano Bar");
			// Tooltip.SetDefault("Pulsing with pure energy");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TitaniumBar, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 1);
			recipe.AddIngredient(ItemID.Nanites, 1);
			recipe.SetResult(this, 2);
			recipe.AddTile(134);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.AdamantiteBar, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 1);
			recipe.AddIngredient(ItemID.Nanites, 1);
			recipe.SetResult(this, 2);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

	}
}
