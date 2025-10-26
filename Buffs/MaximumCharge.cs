using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class MaximumCharge:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Maximum Charge");
			// Description.SetDefault("Maximum mana increased by 100");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.statManaMax2 += 100;
		}
	}
}
