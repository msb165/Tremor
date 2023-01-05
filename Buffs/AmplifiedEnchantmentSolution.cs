using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class AmplifiedEnchantmentSolution:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amplified Enchantment Solution");
			Description.SetDefault("45% chance not to consume flask");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}