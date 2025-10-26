using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class FlyingDutchman:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			// DisplayName.SetDefault("Flying Dutchman");
			// Description.SetDefault("Flies like a butterfly!");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(ModContent.MountType<Mounts.FlyingDutchman>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
