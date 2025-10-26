using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class SteamRangerBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Ranged Enchanting");
			// Description.SetDefault("Increases Brass Chain Repeater damage");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}