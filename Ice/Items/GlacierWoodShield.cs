using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class GlacierWoodShield:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 24;
			Item.value = 110;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood Shield");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
