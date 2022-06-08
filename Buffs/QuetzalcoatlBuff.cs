using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Buffs
{
	public class QuetzalcoatlBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Quetzalcoatl");
			Description.SetDefault("The quetzalcoatl will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<QuetzalcoatlPro>()] > 0)
			{
				modPlayer.quetzalcoatlMinion = true;
			}
			if (!modPlayer.quetzalcoatlMinion)
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