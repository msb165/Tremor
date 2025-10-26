using Terraria.ModLoader;

namespace Tremor.Items
{
	public class YellowPuzzleFragment:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 10000;
			Item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Yellow Puzzle Fragment");
			// Tooltip.SetDefault("");
		}

	}
}
