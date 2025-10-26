using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ToxicHilt:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 22;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Toxic Hilt");
			// Tooltip.SetDefault("");
		}

	}
}
