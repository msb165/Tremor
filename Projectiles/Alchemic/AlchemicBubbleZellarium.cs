using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles.Alchemic
{
	public class AlchemicBubbleZellarium : AlchemistProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(405);
			aiType = 405;
			projectile.friendly = true;
			projectile.timeLeft = 150;
			projectile.light = 0.8f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zellarium Bubble");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			Vector2 drawOrigin = new Vector2(Terraria.GameContent.TextureAssets.Projectile[projectile.type].Value.Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Terraria.GameContent.TextureAssets.Projectile[projectile.type].Value, drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override void Kill(int timeLeft)
		{
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item107, projectile.position);
			int k = Main.rand.Next(3, 4);
			Main.player[projectile.owner].statLife += k;
			Main.player[projectile.owner].HealEffect(k);
			if (projectile.owner == Main.myPlayer)
			{
				int num220 = Main.rand.Next(1, 3);
				for (int num221 = 0; num221 < num220; num221++)
				{
					Vector2 value17 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
					value17.Normalize();
					value17 *= Main.rand.Next(10, 201) * 0.01f;
					Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, value17.X, value17.Y, ModContent.ProjectileType<ZellariumCloudPro>(), projectile.damage, 1f, projectile.owner, 0f, Main.rand.Next(-45, 1));
				}
			}
		}
	}
}
