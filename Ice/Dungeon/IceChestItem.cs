using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Dungeon
{
	public class IceChestItem : ModItem
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
			item.value = 150;
			item.createTile = ModContent.TileType<IceChest>();
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frostbite Chest");
			Tooltip.SetDefault("");
		}

	}
}
