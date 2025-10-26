using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class GoldShield:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 26;
			Item.value = 110;
			Item.rare = 0;
			Item.accessory = true;
			Item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gold Shield");
			// Tooltip.SetDefault("");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed -= 0.40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
