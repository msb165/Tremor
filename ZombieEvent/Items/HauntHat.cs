using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class HauntHat:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);

			Item.useTime = 25;
			Item.useAnimation = 25;

			Item.shoot = ModContent.ProjectileType<TheHauntPro>();
			Item.buffType = ModContent.BuffType<Buffs.HauntPetBuff>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Haunt Hat");
			// Tooltip.SetDefault("Summons a friendly ghost");
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
