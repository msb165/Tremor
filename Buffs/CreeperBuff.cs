using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class CreeperBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Creeper");
			Description.SetDefault("The creeper will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<CreeperStaffPro>()] > 0)
			{
				modPlayer.creeperMinion = true;
			}
			if (!modPlayer.creeperMinion)
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