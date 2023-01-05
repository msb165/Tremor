using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Brass
{
	public class BrassChip:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brass Chip");
			Tooltip.SetDefault("Shoots rockets from the sky when a flask is destroyed\n" +
"If alchemical critical strike chance is more than 30 - alchemical damage is increased by 10%");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 22;
			item.value = 150000;
			item.rare = 5;
			item.defense = 4;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(ModContent.BuffType<Buffs.BrassChipBuff>(), 2);
			if (player.GetModPlayer<MPlayer>().alchemicalCrit >= 30)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
		}
	}
}