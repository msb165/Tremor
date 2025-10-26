using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LifeMachine:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 50;
			Item.height = 26;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;

			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 250000;
			Item.createTile = ModContent.TileType<Tiles.LifeMachineTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Life Machine");
			// Tooltip.SetDefault("Increases maximum health of the player standing near");
		}

	}
}
