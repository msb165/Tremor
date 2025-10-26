using Terraria.ModLoader;

namespace Tremor.Items.Plague
{
	[AutoloadEquip(EquipType.Head)]
	public class PlagueMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 24;

			Item.rare = 2;
			Item.value = 10000;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Plague Mask");
			// Tooltip.SetDefault("'HEE HEE HEE'");
		}

	}
}
