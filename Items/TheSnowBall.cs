using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TheSnowBall:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 27;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 9;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 13800;
			Item.rare = 3;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = true;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.TheSnowBall>();
			Item.shootSpeed = 8f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Snow Ball");
			// Tooltip.SetDefault("");
		}

	}
}
