using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles.Alchemic
{
	public class ToxicFlaskCloud : AlchemistProjectile
	{
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.penetrate = 8;
            projectile.aiStyle = 92;
            AIType = 511;
            projectile.friendly = true;
            projectile.timeLeft = 600;
        }
    }
}