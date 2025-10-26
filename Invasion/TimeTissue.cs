using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class TimeTissue:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 30;

			Item.maxStack = 99;
			Item.value = 10000;
			Item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Time Tissue");
			// Tooltip.SetDefault("'It's about time'.");
		}

	}
}
