using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ZephyrhornBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Zephyrhorn");
			//TODO: Doesn't mention damage?
			Description.SetDefault("Increased minion size");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetDamage(DamageClass.Summon) += 0.1f;
		}
	}
}
