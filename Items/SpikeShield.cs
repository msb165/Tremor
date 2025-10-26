using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class SpikeShield:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 26;
			Item.value = 32000;
			Item.rare = 0;

			Item.accessory = true;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Spiky Shield");
			// Tooltip.SetDefault("Allows you to prick foes");
		}

		public override void UpdateEquip(Player player)
		{
			player.thorns = 1;
		}
	}
}
