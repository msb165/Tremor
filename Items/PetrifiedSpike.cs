using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PetrifiedSpike:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.height = 16;
			Item.maxStack = 99;
			Item.value = 10;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Petrified Spike");
			// Tooltip.SetDefault("");
		}

	}
}
