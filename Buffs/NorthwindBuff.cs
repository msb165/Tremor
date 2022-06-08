using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class NorthwindBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("North wind");
			Description.SetDefault("The frost ghost will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<NorthWindMinion>()] > 0)
			{
				modPlayer.northWind = true;
			}
			if (!modPlayer.northWind)
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