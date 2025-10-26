using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DragonGem:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 28;
			Item.value = 30000;

			Item.rare = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dragon Gem");
			// Tooltip.SetDefault("Increases regeneration during night");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (!Main.dayTime)
			{
				player.lifeRegen += 1;
			}
		}
	}
}
