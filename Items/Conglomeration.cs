using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Conglomeration:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 44;
			item.value = 250000;
			item.rare = 11;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Conglomeration");
			Tooltip.SetDefault("Prolonged after hit invincibility\n" +
"Greatly increased life regeneration\n" +
"Increases maximum life by 140");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed -= 0.2f;
			player.longInvince = true;
			player.lifeRegen += 45;
			player.statLifeMax2 += 140;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SwampClump>());
			recipe.AddIngredient(ModContent.ItemType<ExtraterrestrialRubies>());
			recipe.AddIngredient(ModContent.ItemType<DelightfulClump>());
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}
	}
}
