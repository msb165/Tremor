using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ZootalooEgg:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);

			Item.useTime = 25;
			Item.useAnimation = 25;

			Item.shoot = ModContent.ProjectileType<Projectiles.ZootalooPet>();
			Item.buffType = ModContent.BuffType<Buffs.ZootalooBuff>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zootaloo Egg");
			// Tooltip.SetDefault("Summons an zootaloo junior");
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(Item.buffType, 3600, true);
			}
		}
	}
}
