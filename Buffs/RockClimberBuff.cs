using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class RockClimberBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rock Climber");
			// Description.SetDefault("Grants ability to climb walls");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.spikedBoots = 1;
			player.spikedBoots = 2;
		}
	}
}
