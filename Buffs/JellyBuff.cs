using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class JellyBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Jellyfish Buff");
			Description.SetDefault("The jellyfish will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<JellyfishStaffPro>()] > 0)
			{
				modPlayer.jellyfishMinion = true;
			}
			if (!modPlayer.jellyfishMinion)
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