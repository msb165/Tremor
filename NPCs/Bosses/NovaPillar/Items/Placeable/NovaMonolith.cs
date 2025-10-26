using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs.Bosses.NovaPillar.Tiles;

namespace Tremor.NPCs.Bosses.NovaPillar.Items.Placeable
{
	public class NovaMonolith:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 32;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.rare = 10;
			Item.value = Item.buyPrice(0, 10, 0, 0);
			Item.createTile = ModContent.TileType<NovaMonolithTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nova Monolith");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NovaFragment>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}