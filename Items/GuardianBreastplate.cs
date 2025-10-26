using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class GuardianBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 60;
			Item.width = 22;
			Item.height = 30;
			Item.value = 25000;
			Item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Guardian Breastplate");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientArmorPlate>(), 20);
			recipe.AddIngredient(ModContent.ItemType<Squorb>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
