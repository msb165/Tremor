using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class CorruptorBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Corruptor Junior");
			Description.SetDefault("The corruptor will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<CorruptorStaffPro>()] > 0)
			{
				modPlayer.corruptorMinion = true;
			}
			if (!modPlayer.corruptorMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}