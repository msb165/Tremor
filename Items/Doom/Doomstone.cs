using Terraria.ModLoader;

namespace Tremor.Items.Doom
{
	public class Doomstone:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 20000;
			Item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Doomstone");
			// Tooltip.SetDefault("");
		}

	}
}
