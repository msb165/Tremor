using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class SpaceWhaleMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 20;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Space Whale Mask");
			// Tooltip.SetDefault("");
		}

	}
}
