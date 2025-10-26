using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LivingTombstone:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);

			Item.useTime = 25;
			Item.useAnimation = 25;

			Item.shoot = ModContent.ProjectileType<Projectiles.LivingTombstonePro>();
			Item.buffType = ModContent.BuffType<Buffs.LivingTombstoneBuff>();
			Item.value = 500000;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Living Tombstone");
			// Tooltip.SetDefault("Summons a living tombstone");
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
