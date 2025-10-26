using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ToxicRazorknife:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 29;
			Item.width = 16;
			Item.height = 32;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.ToxicRazorknifePro>();
			Item.shootSpeed = 12f;
			Item.useAnimation = 25;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 100000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item10;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Toxic Razorknife");
			// Tooltip.SetDefault("");
		}

	}
}
