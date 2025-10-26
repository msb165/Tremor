using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class SteamMageBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Magic Enchanting");
			// Description.SetDefault("Increases Brass Stave damage");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}