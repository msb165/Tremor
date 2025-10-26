using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Zephyrhorn:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;
			Item.value = 100000;
			Item.rare = 7;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zephyrhorn");
			// Tooltip.SetDefault("Increases minion damage and size");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(ModContent.BuffType<Buffs.ZephyrhornBuff>(), 2);
		}
	}
}
