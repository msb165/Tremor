using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TheBrain:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 30;

			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Brain");
			// Tooltip.SetDefault("'Braaainzzzz!'");
		}

	}
}
