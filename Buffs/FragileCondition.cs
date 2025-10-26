using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class FragileCondition:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fragile Condition");
			// Description.SetDefault("You deal three times more damage, but your defense is reduced to zero.");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetDamage(DamageClass.Generic) *= 3f;
			MPlayer.GetModPlayer(player).alchemicalDamage *= 3f;
			MPlayer.GetModPlayer(player).fragileContiion = true; // Handles defense reset
		}
	}
}
