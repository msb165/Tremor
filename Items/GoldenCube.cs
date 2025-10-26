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
			Item.CloneDefaults(ItemID.Carrot);

			Item.useTime = 25;
			Item.useAnimation = 25;

			Item.shoot = ModContent.ProjectileType<Projectiles.GoldenWhalePro>();
			Item.buffType = ModContent.BuffType<Buffs.GoldenWhale>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Golden Cube");
			// Tooltip.SetDefault("Summons an golden whale");
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
