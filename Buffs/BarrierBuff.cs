using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class BarrierBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Barrier");
			// Description.SetDefault("Magic is protecting you from damage");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.statDefense += 500;
			if (player.buffTime[buffIndex] == 0)
			{
				player.AddBuff(ModContent.BuffType<BarrierRechargeBuff>(), 7200);
			}
		}
	}
}