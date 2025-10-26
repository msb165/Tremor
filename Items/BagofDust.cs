using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BagofDust:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 36;
			Item.value = 10000;
			Item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bag of Dust");
			// Tooltip.SetDefault("Used for crafting bags with a variety of dust");
		}
	}
}
