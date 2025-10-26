using Terraria.ModLoader;

namespace Tremor.Items.Cyber
{
	[AutoloadEquip(EquipType.Head)]
	public class CyberKingMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cyber King Mask");
			// Tooltip.SetDefault("");
		}

	}
}
