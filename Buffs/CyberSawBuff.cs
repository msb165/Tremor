using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class CyberSawBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Cyber Saw");
			Description.SetDefault("The cyber saw will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<CyberStaffPro>()] > 0)
			{
				modPlayer.cyberMinion = true;
			}
			if (!modPlayer.cyberMinion)
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