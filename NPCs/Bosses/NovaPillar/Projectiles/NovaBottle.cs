using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.NovaPillar.Projectiles
{
	public class NovaBottle:TremorModProjectile
	{

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nova Flask");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
		}
		public override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 28;
			projectile.aiStyle = 2;
			projectile.timeLeft = 1200;
			projectile.hostile = true;
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override void OnKill(int timeLeft)
		{
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item107, projectile.position);
			Gore.NewGore(null, projectile.position, -projectile.oldVelocity * 0.2f, 704, 1f);
			Gore.NewGore(null, projectile.position, -projectile.oldVelocity * 0.2f, 705, 1f);
			Gore.NewGore(null, projectile.position, -projectile.oldVelocity * 0.2f, 705, 1f);
			if (projectile.owner == Main.myPlayer)
			{
				int num220 = Main.rand.Next(5, 8);
				for (int num221 = 0; num221 < num220; num221++)
				{
					Vector2 value17 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
					value17.Normalize();
					value17 *= Main.rand.Next(10, 201) * 0.01f;
					int k = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, value17.X, value17.Y, ModContent.ProjectileType<NovaAlchemistCloud>(), projectile.damage, 1f, projectile.owner, 0f, Main.rand.Next(-45, 1));
					Main.projectile[k].friendly = false;
				}
			}
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			projectile.Kill();
		}
	}
}