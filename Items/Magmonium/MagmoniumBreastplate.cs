using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Magmonium
{
	[AutoloadEquip(EquipType.Body)]
	public class MagmoniumBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 25;
			Item.width = 22;
			Item.height = 30;
			Item.value = 60000;
			Item.rare = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magmonium Breastplate");
			// Tooltip.SetDefault("12% increased damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.12f;
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.12f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<MagmoniumBar>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
