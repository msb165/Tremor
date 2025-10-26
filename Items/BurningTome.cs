using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BurningTome:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 7;
			//Item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.mana = 6;
			Item.useStyle = 5;
			//Item.shoot = ModContent.ProjectileType<Projectiles.BurningTome>();
			Item.shoot = 376;
			Item.shootSpeed = 26f;
			Item.knockBack = 4;
			Item.value = 12000;
			Item.rare = 2;
			//Item.UseSound = SoundID.Item9;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Burning Tome");
			// Tooltip.SetDefault("");
		}

	}
}
