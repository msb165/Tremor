using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Invasion
{

	public class ParadoxDrillPro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 22;
			projectile.height = 40;
			projectile.aiStyle = 20;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.DamageType = DamageClass.Melee;
		}

		public override void AI()
		{
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<CyberDust>(), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1f);
			Main.dust[dust].noGravity = true;
		}

	}
}