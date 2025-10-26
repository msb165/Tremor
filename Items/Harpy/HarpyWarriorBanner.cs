using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Harpy
{
	public class HarpyWarriorBanner:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 10;
			Item.height = 24;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.rare = 1;
			Item.value = Item.buyPrice(0, 0, 10, 0);
			Item.createTile = ModContent.TileType<Tiles.MonsterBanner>();
			Item.placeStyle = 70;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Harpy Warrior Banner");
			// Tooltip.SetDefault("");
		}

	}
}
