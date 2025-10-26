using Terraria.ModLoader;

namespace Tremor.Items.Ancient
{
	public class AncientArmorPlate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 12000;
			Item.rare = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ancient Armor Plate");
			// Tooltip.SetDefault("");
		}

	}
}
