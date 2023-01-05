using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles;

namespace Tremor.Buffs
{
	public class EmeraldStoneBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Emeraldy");
			Description.SetDefault("It lights up the area");
			Main.buffNoTimeDisplay[Type] = true;
			Main.lightPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			modPlayer.emeraldy = true;
			bool petProjectileNotSpawned = true;
			if (player.ownedProjectileCounts[ModContent.ProjectileType<Emeraldy>()] > 0)
			{
				petProjectileNotSpawned = false;
			}
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(null, player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, ModContent.ProjectileType<Projectiles.Emeraldy>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
			if ((player.controlDown && player.releaseDown))
			{
				//if (player.doubleTapCardinalTimer[0] > 0 && player.doubleTapCardinalTimer[0] != 15)
				//{
				for (int j = 0; j < 1000; j++)
				{
					if (Main.projectile[j].active && Main.projectile[j].type == ModContent.ProjectileType<Projectiles.Emeraldy>() && Main.projectile[j].owner == player.whoAmI)
					{
						Projectile lightpet = Main.projectile[j];
						Vector2 vectorToMouse = player.Center - lightpet.Center;
						lightpet.velocity += 5f * Vector2.Normalize(vectorToMouse);
					}
				}
				//}
			}
		}

	}
}