using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class TheCadenceBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Cadence");
			// Description.SetDefault("Flasks attack your enemies with souls");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}