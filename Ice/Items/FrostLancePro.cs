using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class FrostLancePro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(66);
			AIType = 66;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frost Lance");
		}

	}
}
