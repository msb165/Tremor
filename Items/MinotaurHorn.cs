using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MinotaurHorn:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Horn");
			Tooltip.SetDefault("");
		}

	}
}
