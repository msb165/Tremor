using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ChemikazeBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Chemikaze");
			// Description.SetDefault("Alchemical projectiles leave five explosions");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}