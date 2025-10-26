using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EvilCup:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 10000;
			Item.rare = 3;
			Item.maxStack = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Evil Cup");
			// Tooltip.SetDefault("Increases monsters spawn rate");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.enemySpawns = true;
		}
	}
}
