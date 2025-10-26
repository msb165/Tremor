using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class BirbStaffBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Birb");
			// Description.SetDefault("A birb will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<BirbStaffPro>()] > 0)
			{
				modPlayer.birbStaff = true;
			}
			if (!modPlayer.birbStaff)
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