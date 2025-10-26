using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ManaSaving:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mana Saving");
			// Description.SetDefault("Mana cost is reduced by 50%");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.manaCost -= 0.50f;
		}
	}
}
