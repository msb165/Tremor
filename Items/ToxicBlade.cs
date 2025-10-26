using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ToxicBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 36;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Toxic Blade");
			// Tooltip.SetDefault("");
		}

	}
}
