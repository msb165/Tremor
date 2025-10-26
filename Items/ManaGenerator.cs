using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ManaGenerator:TremorModItem
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
			Item.rare = 9;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 300000;
			Item.createTile = ModContent.TileType<Tiles.ManaGeneratorTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mana Generator");
			// Tooltip.SetDefault("Decreases mana cost of the player standing near");
		}

	}
}
