using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class DesertEmperorSetBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Desert Wasp");
			// Description.SetDefault("Releases a wasp to attack enemies when a flask explodes");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}