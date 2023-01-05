using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DrippingRoot:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 26;
			item.maxStack = 99;
			item.value = 250;
			item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dripping Root");
			Tooltip.SetDefault("");
		}

	}
}
