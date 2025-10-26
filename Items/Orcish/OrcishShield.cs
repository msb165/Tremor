using Terraria.ModLoader;

namespace Tremor.Items.Orcish
{
	[AutoloadEquip(EquipType.Shield)]
	public class OrcishShield:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 30;
			Item.value = 110;
			Item.rare = 1;
			Item.accessory = true;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Orcish Shield");
			// Tooltip.SetDefault("");
		}

	}
}
