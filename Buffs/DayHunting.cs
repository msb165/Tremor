using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class DayHunting:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Day Hunting");
			Description.SetDefault("Increases all stats during daytime");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (Main.dayTime)
			{
				player.GetDamage(DamageClass.Generic) += 0.15f;
				player.GetCritChance(DamageClass.Generic) += 12;
				player.moveSpeed += 0.25f;
			}
		}
	}
}
