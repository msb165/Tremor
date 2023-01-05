using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class NecroShield:TremorModItem
	{
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 30;
			item.value = 110;
			item.rare = 0;
			item.accessory = true;
			item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Necro Shield");
			Tooltip.SetDefault("10% increased minion damage\n" +
							   "10% increased magic critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Magic) += 10;
			player.GetDamage(DamageClass.Summon) += 0.1f;
		}
	}
}
