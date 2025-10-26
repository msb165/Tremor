using Terraria;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class DreadLancePro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(66);
			AIType = 66;
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool())
			{
				target.AddBuff(39, 180, false);
			}
		}
	}
}
