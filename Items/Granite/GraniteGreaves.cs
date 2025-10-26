using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Granite
{
	[AutoloadEquip(EquipType.Legs)]
	public class GraniteGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 2500;
			Item.rare = 1;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Granite Greaves");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GraniteBlock, 45);
			recipe.AddIngredient(ModContent.ItemType<StoneofLife>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
