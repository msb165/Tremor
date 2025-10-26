using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RockHorn:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 14;
			Item.height = 22;
			Item.maxStack = 999;
			Item.rare = 3;
			Item.value = Item.buyPrice(0, 0, 5, 0);
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rock Horn");
			// Tooltip.SetDefault("");
		}

	}
}
