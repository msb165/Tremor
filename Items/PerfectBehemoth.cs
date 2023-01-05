using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PerfectBehemoth:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 30;
			item.DamageType = DamageClass.Throwing;
			item.width = 40;
			item.height = 40;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 50000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<Projectiles.PerfectBehemothPro>();
			item.shootSpeed = 8f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Perfect Behemoth");
			Tooltip.SetDefault("");
		}

	}
}
