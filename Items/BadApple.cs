using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BadApple:TremorModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Carrot);

			item.useTime = 25;
			item.useAnimation = 25;

			item.shoot = ModContent.ProjectileType<Projectiles.GurdPet>();
			item.buffType = ModContent.BuffType<Buffs.GurdPetBuff>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bad Apple");
			Tooltip.SetDefault("Summons a gurd pet");
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
