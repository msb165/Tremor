using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.Projectiles
{
	public class CornJavelinPro:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 4;
			projectile.height = 4;
			projectile.friendly = true;
			projectile.aiStyle = 1;
			projectile.timeLeft = 1200;
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Corn Javelin Pro");

		}

		public override void OnKill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, DustID.Stone, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 2f, 100, default(Color), 2f);
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Dig, projectile.position);//Variant 0

			if (Main.rand.NextBool(5))
			{
				Item.NewItem(null, projectile.position, projectile.width, projectile.height, ModContent.ItemType<CornJavelin>());
			};
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}
	}
}
