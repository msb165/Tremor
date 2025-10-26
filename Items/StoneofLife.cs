using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StoneofLife:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 16;
			Item.maxStack = 99;
			Item.value = 500;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stone of Life");
			// Tooltip.SetDefault("");
		}

	}
}
