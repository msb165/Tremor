using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class PixieQueenMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 22;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Pixie Queen Mask");
			// Tooltip.SetDefault("");
		}

	}
}
