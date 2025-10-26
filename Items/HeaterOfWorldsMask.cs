using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class HeaterOfWorldsMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 32;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Heater of Worlds Mask");
			// Tooltip.SetDefault("");
		}

	}
}
