using Terraria.ModLoader;

namespace Tremor.Items
{
	public class AlphaClaw:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 30;

			Item.maxStack = 99;
			Item.value = 10;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Alpha Claw");
			// Tooltip.SetDefault("A claw of a powerful wolf");
		}

	}
}
