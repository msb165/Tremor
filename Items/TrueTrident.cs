using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrueTrident:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 43;
			Item.width = 50;
			Item.height = 50;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.TrueTridentProjectile>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 15;
			Item.value = 40000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("True Trident");
			// Tooltip.SetDefault("");
		}

	}
}
