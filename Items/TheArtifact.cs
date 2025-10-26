using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TheArtifact:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);

			Item.useTime = 25;
			Item.useAnimation = 25;

			Item.shoot = ModContent.ProjectileType<Projectiles.AnnoyingDog>();
			Item.buffType = ModContent.BuffType<Buffs.AnnoyingDogBuff>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Artifact");
			// Tooltip.SetDefault("Summons annoying dog");
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
