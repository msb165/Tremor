using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.Motherboard.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class MotherboardMask:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 28;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Motherboard Mask");
			// Tooltip.SetDefault("");
		}
	}
}
