using Terraria.ModLoader;

namespace Tremor.Invasion
{
	[AutoloadEquip(EquipType.Head)]
	public class VioleumMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 32;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Violeum Mask");
			// Tooltip.SetDefault("");
		}

		//TODO: [Skipped for 1.4] DrawHead
		//public override bool DrawHead() => false;
	}
}
