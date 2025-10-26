using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class SteamSwordBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Melee Enchanting");
			// Description.SetDefault("Increases Brass Rapier and Glaive damage");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}