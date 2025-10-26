using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ScamperBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Scamper");
			// Description.SetDefault("75% increased movement speed");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.moveSpeed += 0.75f;
		}
	}
}
