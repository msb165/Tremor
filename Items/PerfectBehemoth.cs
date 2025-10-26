using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PerfectBehemoth:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 30;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 50000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.PerfectBehemothPro>();
			Item.shootSpeed = 8f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Perfect Behemoth");
			// Tooltip.SetDefault("");
		}

	}
}
