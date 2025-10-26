using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Bloomstone:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 28;
			Item.value = 50000;

			Item.rare = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bloomstone");
			// Tooltip.SetDefault("You are glowing during night");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (!Main.dayTime)
			{
				player.AddBuff(11, 10);
				player.AddBuff(12, 10);
			}
		}
	}
}
