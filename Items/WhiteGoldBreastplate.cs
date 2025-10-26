using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class WhiteGoldBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 10000;
			Item.rare = 11;
			Item.defense = 35;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("White Gold Breastplate");
			// Tooltip.SetDefault("25% increased melee and ranged critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Ranged) += 25;
			player.GetCritChance(DamageClass.Melee) += 25;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<WhiteGoldBar>(), 18);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.DivineForgeTile>());
			recipe.AddRecipe();
		}
	}
}
