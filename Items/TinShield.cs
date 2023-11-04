using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class TinShield:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 30;
			item.value = 110;
			item.rare = 0;
			item.accessory = true;
			item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tin Shield");
			Tooltip.SetDefault("");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed -= 0.10f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TinBar, 15);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
