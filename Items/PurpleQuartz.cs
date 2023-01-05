using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PurpleQuartz:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 12000;
			item.rare = 9;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Quartz");
			Tooltip.SetDefault("");
		}

	}
}
