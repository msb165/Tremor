using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class NitroBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Nitro");
			// Description.SetDefault("Alchemical projectiles leave death flames");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}