using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class BottledSoulOfFlight:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			// DisplayName.SetDefault("Bottled Soul of Flight");
			// Description.SetDefault("20% increased jump height");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.jumpSpeedBoost += 0.2f;
		}
	}
}
