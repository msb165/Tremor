using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LongFuse:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 25000;
			Item.rare = 5;
			Item.accessory = true;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Long Fuse");
			// Tooltip.SetDefault("Alchemical weapons throws further");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(ModContent.BuffType<Buffs.LongFuseBuff>(), 2);
		}
	}
}
