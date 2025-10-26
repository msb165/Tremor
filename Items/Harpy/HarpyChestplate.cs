using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Harpy
{
	[AutoloadEquip(EquipType.Body)]
	public class HarpyChestplate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;
			Item.value = 100;

			Item.rare = 2;
			Item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Harpy Chestplate");
			// Tooltip.SetDefault("Increases jump height");
		}

		public override void UpdateEquip(Player player)
		{
			player.jumpBoost = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.Feather, 13);
			recipe.SetResult(this);
			recipe.AddTile(86);
			recipe.AddRecipe();
		}
	}
}
