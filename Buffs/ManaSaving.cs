using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ManaSaving:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Mana Saving");
			Description.SetDefault("Mana cost is reduced by 50%");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.manaCost -= 0.50f;
		}
	}
}
