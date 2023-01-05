using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class HuskyBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Husky");
			Description.SetDefault("A husky will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<HuskyStaffPro>()] > 0)
			{
				modPlayer.huskyStaff = true;
			}
			if (!modPlayer.huskyStaff)
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