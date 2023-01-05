using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class AlchemistGloveBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Master Alchemist Glove");
			Description.SetDefault("Alchemic weapons throw two flasks");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}