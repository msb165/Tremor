using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class FatSpider : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			DisplayName.SetDefault("Fat Spider");
			Description.SetDefault("Cute human-eater");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(ModContent.MountType<Mounts.Spider>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
