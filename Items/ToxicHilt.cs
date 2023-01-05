using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ToxicHilt:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 22;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Toxic Hilt");
			Tooltip.SetDefault("");
		}

	}
}
