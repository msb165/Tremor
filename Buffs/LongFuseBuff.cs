using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class LongFuseBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Long fuse");
			// Description.SetDefault("Alchemic weapon throws further");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}