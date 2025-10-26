using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TechnologyofDionysus:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 28;

			Item.value = 100000;
			Item.rare = 6;
			Item.accessory = true;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Technology of Dionysus");
			// Tooltip.SetDefault("Enemies are less likely to target you");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.aggro -= 400;
		}
	}
}
