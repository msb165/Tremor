using Terraria.ModLoader;
using Tremor.Ice.Tree;

namespace Tremor.Ice
{
	public class IceBlockB:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<VeryVeryIce>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Everfrost Block");
			// Tooltip.SetDefault("");
		}

	}
}
