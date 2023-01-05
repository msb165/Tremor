using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class WhiteGoldGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 10000;
			item.rare = 11;
			item.defense = 32;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Gold Greaves");
			Tooltip.SetDefault("50% increased movement speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<WhiteGoldBar>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.DivineForgeTile>());
			recipe.AddRecipe();
		}

	}
}
