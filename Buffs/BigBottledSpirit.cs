using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class BigBottledSpirit:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Big Bottled Spirit");
			// Description.SetDefault("Shoots four homing souls when using a flask");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}