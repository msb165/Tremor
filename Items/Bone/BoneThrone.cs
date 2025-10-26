using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Bone
{
	public class BoneThrone:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
			Item.height = 64;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.BoneThrone>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bone Throne");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Bone, 75);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
