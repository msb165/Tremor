using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class OrangeKnightBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.value = 10000;
			Item.rare = 2;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Orange Knight Breastplate");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GrayKnightBreastplate>(), 3);
			recipe.AddIngredient(ItemID.Amber, 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
