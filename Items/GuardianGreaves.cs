using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class GuardianGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			item.defense = 50;
			item.width = 22;
			item.height = 18;
			item.value = 25000;
			item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Guardian Greaves");
			Tooltip.SetDefault("");
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
