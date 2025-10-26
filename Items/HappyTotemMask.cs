using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class HappyTotemMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 36;
			Item.height = 24;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Happy Totem Mask");
			// Tooltip.SetDefault("");
		}

	}
}
