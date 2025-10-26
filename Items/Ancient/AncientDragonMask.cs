using Terraria.ModLoader;

namespace Tremor.Items.Ancient
{
	[AutoloadEquip(EquipType.Head)]
	public class AncientDragonMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 24;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ancient Dragon Mask");
			// Tooltip.SetDefault("");
		}

	}
}
