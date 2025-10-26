using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class AngryShard:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 14;
			Item.height = 22;
			Item.maxStack = 999;
			Item.rare = 10;
			Item.value = Item.buyPrice(0, 10, 0, 0);
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Angry Shard");
			// Tooltip.SetDefault("");
		}

	}
}
