using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class ZombatBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Zombat");
			Description.SetDefault("The zombat will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<ZombatStaffPro>()] > 0)
			{
				modPlayer.zombatMinion = true;
			}
			if (!modPlayer.zombatMinion)
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