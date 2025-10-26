using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BicholmereSpear:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 20;
			Item.width = 14;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Throwing;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.BicholmereSpearPro>();
			Item.shootSpeed = 15f;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 1000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bicholmere Spear");
			// Tooltip.SetDefault("");
		}

	}
}
