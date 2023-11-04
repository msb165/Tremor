using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class AnnoyingDog:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Bunny);

			AIType = ProjectileID.Bunny;
			Main.projFrames[projectile.type] = 8;
			projectile.width = 46;
			projectile.height = 38;
			Main.projPet[projectile.type] = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Annoying Dog");

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
				modPlayer.AnnoyingDog = false;
			}
			if (modPlayer.AnnoyingDog)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}
