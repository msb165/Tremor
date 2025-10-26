using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class RuinAltarBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ruin Powers");
			// Description.SetDefault("Ancient powers allow you to summon Ancient Dragon");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			modPlayer.ruinAltar = true;
		}
	}
}
