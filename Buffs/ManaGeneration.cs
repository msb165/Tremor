using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ManaGeneration:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			// DisplayName.SetDefault("Mana Generation");
			// Description.SetDefault("Lowered mana cost for magic weapons");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.manaCost -= 0.70f;
		}
	}
}
