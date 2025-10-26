using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class FungusSpear:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(66);

			AIType = 66;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("FungusSpear");

		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(4))
			{
				target.AddBuff(31, 120, false);
			}
		}

	}
}
