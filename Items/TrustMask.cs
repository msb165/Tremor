using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class TrustMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 32;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Doom Mask");
			// Tooltip.SetDefault("");
		}

	}
}
