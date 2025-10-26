using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DrippingRoot:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 26;
			Item.maxStack = 99;
			Item.value = 250;
			Item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dripping Root");
			// Tooltip.SetDefault("");
		}

	}
}
