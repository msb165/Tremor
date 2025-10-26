using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class Brutty:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(269);

			AIType = 269;
			Main.projFrames[projectile.type] = 7;
			projectile.width = 32;
			projectile.height = 28;
			Main.projPet[projectile.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brutty");

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
				modPlayer.Brutty = false;
			}
			if (modPlayer.Brutty)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}
