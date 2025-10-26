using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class LeopardHat:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 22;
			Item.value = 100000;
			Item.rare = 11;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Leopard Hat");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FashionableHat>());
			recipe.AddIngredient(2282);
			recipe.SetResult(this);
			recipe.AddTile(86);
			recipe.AddRecipe();
		}

	}
}
