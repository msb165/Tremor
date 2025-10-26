using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class NightmarePants:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 22;
			Item.width = 22;
			Item.height = 18;
			Item.value = 25000;
			Item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightmare Pants");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 20);
			recipe.AddIngredient(ModContent.ItemType<PurpleQuartz>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
