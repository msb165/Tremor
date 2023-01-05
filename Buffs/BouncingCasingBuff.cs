using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class BouncingCasingBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Bouncing Casing");
			Description.SetDefault("Alchemical flasks bounce off walls");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}