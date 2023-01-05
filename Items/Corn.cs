using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Corn:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 26;
			item.maxStack = 99;
			item.value = 10;
			item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corn");
			Tooltip.SetDefault("");
		}

	}
}
