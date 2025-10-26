using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RedFeather:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 3000;
			Item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Feather");
			// Tooltip.SetDefault("");
		}

	}
}
