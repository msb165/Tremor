using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class GuardianGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 50;
			Item.width = 22;
			Item.height = 18;
			Item.value = 25000;
			Item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Guardian Greaves");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientArmorPlate>(), 16);
			recipe.AddIngredient(ModContent.ItemType<Squorb>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
