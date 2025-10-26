using Terraria;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class FrostByteEye:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 22;
			Item.value = 6000;

			Item.rare = 1;
			Item.accessory = true;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frostbyte Eye");
			// Tooltip.SetDefault("10% increased move speed and increased jump height");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.moveSpeed += 0.1f;
			player.jumpBoost = true;
		}
	}
}
