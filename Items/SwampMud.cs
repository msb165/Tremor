using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SwampMud:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 999;
			Item.rare = 0;
			//TODO: Needs tile
			//Item.createTile = ModContent.TileType<SwampMud>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Swamp Mud");
			// Tooltip.SetDefault("");
		}

	}
}
