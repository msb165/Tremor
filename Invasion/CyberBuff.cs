using Terraria;
using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class CyberBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Cyber Stray");
			Description.SetDefault("Cyber stray fights for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<Mini_Cyber>()] > 0)
			{
				modPlayer.miniCyber = true;
			}
			if (!modPlayer.miniCyber)
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