using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class EnchantedBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Enchanted");
			// Description.SetDefault("Enchanted weapons have more power");
			//Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}
