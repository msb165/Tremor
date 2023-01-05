using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class HappyTotemMask:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 36;
			item.height = 24;
			item.rare = 1;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Happy Totem Mask");
			Tooltip.SetDefault("");
		}

	}
}
