using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class GlacierWoodLeggings:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 500;
			Item.rare = 1;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood Leggings");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
