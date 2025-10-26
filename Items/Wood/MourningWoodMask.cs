using Terraria.ModLoader;

namespace Tremor.Items.Wood
{
	[AutoloadEquip(EquipType.Head)]
	public class MourningWoodMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 24;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mourning Wood Mask");
			// Tooltip.SetDefault("");
		}

	}
}
