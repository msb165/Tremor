using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class LuxoriousBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{
			Item.defense = 20;
			Item.width = 22;
			Item.height = 30;
			Item.value = 2500;
			Item.rare = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Luxorious Breastplate");
			// Tooltip.SetDefault("12% increased mining speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.pickSpeed -= 0.12f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<EvershinyBar>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
