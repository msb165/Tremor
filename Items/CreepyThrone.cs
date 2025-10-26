using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CreepyThrone:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
			Item.height = 64;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.CreepyThrone>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Creepy Throne");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SilverBar, 25);
			recipe.AddIngredient(ModContent.ItemType<MinotaurHorn>(), 2);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TungstenBar, 25);
			recipe.AddIngredient(ModContent.ItemType<MinotaurHorn>(), 2);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
