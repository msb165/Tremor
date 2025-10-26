using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Coral
{
	[AutoloadEquip(EquipType.Body)]
	public class CoralChestplate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;
			Item.value = 100;
			Item.rare = 1;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Coral Chestplate");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Coral, 12);
			recipe.AddIngredient(ItemID.Seashell, 4);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
