using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CosmicFuel:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 20;

			Item.value = 10000000;
			Item.rare = 11;
			ItemID.Sets.ItemNoGravity[Item.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cosmic Fuel");
			// Tooltip.SetDefault("'Infinity energy!'");
		}

	}
}
