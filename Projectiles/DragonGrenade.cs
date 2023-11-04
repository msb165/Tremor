using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class DragonGrenade:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(139);

			AIType = 139;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DragonGrenade");

		}

	}
}
