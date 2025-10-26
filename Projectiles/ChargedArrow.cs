using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	//ported from my tAPI mod because I don't want to make artwork
	public class ChargedArrow:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 16;
			projectile.height = 40;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = -2;
			projectile.tileCollide = true;
			projectile.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Charged Arrow");

		}

		public override void OnKill(int timeLeft)
		{
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item93, projectile.position);
			Projectile.NewProjectile(null, projectile.Center.X, projectile.Center.Y, 0f, 0f, ModContent.ProjectileType<Projectiles.ChargedArrowBoom>(), projectile.damage, projectile.knockBack, projectile.owner, 0f, 0f);
		}

	}
}
