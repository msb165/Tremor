using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SwampMud:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 999;
			item.rare = 0;
			//TODO: Needs tile
			//item.createTile = ModContent.TileType<SwampMud>();
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Swamp Mud");
			Tooltip.SetDefault("");
		}

	}
}
