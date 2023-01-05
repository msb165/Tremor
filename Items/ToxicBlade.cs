using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ToxicBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 28;
			item.height = 36;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Toxic Blade");
			Tooltip.SetDefault("");
		}

	}
}
