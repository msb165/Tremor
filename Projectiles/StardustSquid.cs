using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class StardustSquid:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);

			AIType = ProjectileID.ZephyrFish;
			Main.projFrames[projectile.type] = 4;
			projectile.width = 34;
			projectile.height = 40;
			Main.projPet[projectile.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stardust Squid");

		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.bunny = false; // Relic from AIType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.dead)
			{
				modPlayer.stardustSquid = false;
			}
			if (modPlayer.stardustSquid)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}
