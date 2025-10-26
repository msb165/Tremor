using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs.Bosses.NovaPillar.Tiles;

namespace Tremor.NPCs.Bosses.NovaPillar.Items.Placeable
{
	public class NovaFragmentBlock:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 22;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.rare = 0;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<NovaBlock>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nova Fragment Block");
		}

		public override void AddRecipes()
		{
			var recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NovaFragment>(), 1);
			recipe.AddIngredient(ItemID.StoneBlock, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}
