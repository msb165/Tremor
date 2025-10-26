using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Steel
{
	[AutoloadEquip(EquipType.Body)]
	public class SteelChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;

			Item.value = 600;
			Item.rare = 1;
			Item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Steel Chestplate");
			// Tooltip.SetDefault("3% increased ranged critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Ranged) += 3;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 23);
			recipe.AddIngredient(ModContent.ItemType<LeatherShirt>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
