using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class Icicle:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 60;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Icicle");
			// Tooltip.SetDefault("");
		}

	}
}
