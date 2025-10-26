using Terraria.ModLoader;

namespace Tremor.Items.Brutallisk
{
	[AutoloadEquip(EquipType.Head)]
	public class BrutalliskMask:TremorModItem
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
			// DisplayName.SetDefault("Brutallisk Mask");
			// Tooltip.SetDefault("");
		}

	}
}
