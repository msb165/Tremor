using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Granite
{
	[AutoloadEquip(EquipType.Body)]
	public class GraniteChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;
			Item.value = 2500;
			Item.rare = 1;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Granite Chestplate");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GraniteBlock, 75);
			recipe.AddIngredient(ModContent.ItemType<StoneofLife>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

	}
}
