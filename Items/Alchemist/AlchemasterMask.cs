using Terraria.ModLoader;

namespace Tremor.Items.Alchemist
{
	[AutoloadEquip(EquipType.Head)]
	public class AlchemasterMask:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 24;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Alchemaster Mask");
			// Tooltip.SetDefault("");
		}

	}
}
