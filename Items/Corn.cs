using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Corn:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 26;
			Item.maxStack = 99;
			Item.value = 10;
			Item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Corn");
			// Tooltip.SetDefault("");
		}

	}
}
