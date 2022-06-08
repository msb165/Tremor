using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class WhiteGoldBreastplate : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 10000;
			item.rare = 11;
			item.defense = 35;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Gold Breastplate");
			Tooltip.SetDefault("25% increased melee and ranged critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedCrit += 25;
			player.meleeCrit += 25;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<WhiteGoldBar>(), 18);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.DivineForgeTile>());
			recipe.AddRecipe();
		}
	}
}
