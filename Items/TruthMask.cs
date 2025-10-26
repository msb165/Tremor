using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class TruthMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 28;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Truth Mask");
			// Tooltip.SetDefault("");
		}

	}
}
