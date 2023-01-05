using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class CursedBannerBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("The Cursed Banner");
			Description.SetDefault("Increases all critical strike chance by 25");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetCritChance(DamageClass.Generic) += 25;
			player.GetModPlayer<MPlayer>().alchemicalCrit += 25;
		}
	}
}