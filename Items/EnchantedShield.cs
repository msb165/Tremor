using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class EnchantedShield:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 30;
			Item.value = 15000;

			Item.rare = 2;
			Item.accessory = true;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Enchanted Shield");
			/* Tooltip.SetDefault("Increases maximum mana by 40\n" +
"10% decreased magic damage"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 40;
			player.GetDamage(DamageClass.Magic) -= 0.1f;
		}
	}
}
