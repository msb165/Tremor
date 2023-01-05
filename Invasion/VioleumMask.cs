using Terraria.ModLoader;

namespace Tremor.Invasion
{
	[AutoloadEquip(EquipType.Head)]
	public class VioleumMask:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 32;
			item.rare = 1;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Violeum Mask");
			Tooltip.SetDefault("");
		}

		//TODO: [Skipped for 1.4] DrawHead
		//public override bool DrawHead() => false;
	}
}
