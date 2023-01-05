using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class GoblinStaffBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Goblin Staff");
			Description.SetDefault("The goblin will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<GoblinStaffPro>()] > 0)
			{
				modPlayer.goblinMinion = true;
			}
			if (!modPlayer.goblinMinion)
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