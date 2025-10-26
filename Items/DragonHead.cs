using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DragonHead:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 10;
			Item.rare = 2;
			Item.noMelee = true;
			Item.useStyle = 5;
			Item.useAnimation = 40;
			Item.useTime = 40;
			Item.knockBack = 7.5F;
			Item.damage = 19;
			Item.scale = 1.1F;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.DragonHead>();
			Item.shootSpeed = 13f;
			Item.UseSound = SoundID.Item1;
			Item.DamageType = DamageClass.Melee;
			Item.channel = true;
			Item.value = 30000;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dragon Head");
			// Tooltip.SetDefault("Has 33% chance to spawn fire when hitting an enemy");
		}

	}
}
