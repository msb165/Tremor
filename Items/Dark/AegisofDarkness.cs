using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Dark
{
	[AutoloadEquip(EquipType.Shield)]
	public class AegisofDarkness:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 30;
			Item.value = 110;
			Item.rare = 0;

			Item.accessory = true;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Aegis of Darkness");
			/* Tooltip.SetDefault("10% increased minion damage\n" +
							   "10% increased magic critical strike chance\n" +
							   "8% decreased magic damage\n" +
							   "Increases maximum mana by 40"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Magic) += 10;
			player.GetDamage(DamageClass.Summon) += 0.1f;
			player.statManaMax2 += 40;
			player.GetDamage(DamageClass.Magic) -= 0.08f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<EnchantedShield>(), 1);
			recipe.AddIngredient(ModContent.ItemType<NecroShield>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
