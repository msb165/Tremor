using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GoldenCube:TremorModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Carrot);

			item.useTime = 25;
			item.useAnimation = 25;

			item.shoot = ModContent.ProjectileType<Projectiles.GoldenWhalePro>();
			item.buffType = ModContent.BuffType<Buffs.GoldenWhale>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Cube");
			Tooltip.SetDefault("Summons an golden whale");
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
