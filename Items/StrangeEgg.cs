using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StrangeEgg:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);

			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.rare = 11;

			Item.shoot = ModContent.ProjectileType<Projectiles.Brutty>();
			Item.buffType = ModContent.BuffType<Buffs.BruttyBuff>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Strange Egg");
			// Tooltip.SetDefault("Summons an brutty");
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
