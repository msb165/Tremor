using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class MeatShield:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 26;
			Item.value = 11000;
			Item.rare = 6;
			Item.accessory = true;
			Item.defense = 12;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Meat Shield");
			// Tooltip.SetDefault("");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed -= 0.40f;
			player.aggro += 400;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.FleshKnuckles, 1);
			recipe.AddIngredient(ModContent.ItemType<HardBulwark>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.PutridScent, 1);
			recipe.AddIngredient(ModContent.ItemType<HardBulwark>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}
	}
}
