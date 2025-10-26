using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wood;

namespace Tremor.Items
{
	public class TikiArmor:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 34;
			Item.value = 150000;
			Item.rare = 3;

			Item.defense = 4;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tiki Armor");
			// Tooltip.SetDefault("15% increased minion damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Summon) += 0.15f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<JungleAlloy>(), 1);
			recipe.AddIngredient(ModContent.ItemType<WoodenFrame>(), 1);
			recipe.AddIngredient(ItemID.Vine, 5);
			recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
