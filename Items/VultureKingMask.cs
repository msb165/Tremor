using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class VultureKingMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 22;
			Item.value = 20000;
			Item.rare = 0;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rukh Mask");
			// Tooltip.SetDefault("");
		}

	}
}
