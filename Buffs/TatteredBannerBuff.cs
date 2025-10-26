using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class TatteredBannerBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Tattered Banner");
			// Description.SetDefault("25% increased damage");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetDamage(DamageClass.Generic) += 0.25f;
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.25f;
		}
	}
}