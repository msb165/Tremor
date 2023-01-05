using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LifeMachine:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 50;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;

			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 250000;
			item.createTile = ModContent.TileType<Tiles.LifeMachineTile>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Life Machine");
			Tooltip.SetDefault("Increases maximum health of the player standing near");
		}

	}
}
