using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class Warkee:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);

			AIType = ProjectileID.ZephyrFish;
			Main.projFrames[projectile.type] = 4;
			projectile.width = 26;
			projectile.height = 34;
			Main.projPet[projectile.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Warkee");

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
				modPlayer.warkee = false;
			}
			if (modPlayer.warkee)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}