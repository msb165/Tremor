using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class DripplerBuff : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			DisplayName.SetDefault("Drippler");
			Description.SetDefault("It flies. And flows.");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(ModContent.MountType<Mounts.DripplerMount>(), player);
			player.buffTime[buffIndex] = 10;
			player.slowFall = true;
		}
	}
}
