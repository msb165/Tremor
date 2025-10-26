using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.RedSteel
{
	[AutoloadEquip(EquipType.Legs)]
	public class RedSteelGreaves:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.value = 360;
			Item.rare = 2;
			Item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Steel Greaves");
			// Tooltip.SetDefault("20% increased movement speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.2f;
		}

		public override void AddRecipes()
		{
			//ModRecipe recipe = new ModRecipe();
			//recipe.AddIngredient(ModContent.ItemType<RedSteelArmorPiece>(), 5);
			//recipe.AddIngredient(ModContent.ItemType<RedSteelBar>(), 6);
			//recipe.SetResult(this);
			//recipe.AddTile(16);
			//recipe.AddRecipe();
		}

	}
}
