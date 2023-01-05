using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HealthBooster:TremorModItem
	{
		public override void SetDefaults()
		{

			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 4;
			item.width = 22;
			item.UseSound = SoundID.Item43;
			item.height = 18;
			item.buffType = ModContent.BuffType<Buffs.HealthBooster>();
			item.value = 5160000;
			item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Health Booster");
			Tooltip.SetDefault("Regenerates health every minute");
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}

	}
}
