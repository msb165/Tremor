using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class BarrierRechargeBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Barrier Recharging");
			// Description.SetDefault("Magic barrier can't appear");
			Main.debuff[Type] = true;
		}
	}
}