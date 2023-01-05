using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TheSpike:TremorModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(3279);

			item.damage = 23;
			item.width = 30;
			item.height = 26;
			item.shoot = ModContent.ProjectileType<Projectiles.TheSpikePro>();
			item.knockBack = 4;
			item.value = 30000;
			item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Spike");
			Tooltip.SetDefault("");
		}

	}
}
