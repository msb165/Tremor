using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LasCannon:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 500;
			Item.DamageType = DamageClass.Ranged;
			Item.expert = true;
			//Item.melee = false;
			Item.width = 90;
			Item.height = 36;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.useAmmo = AmmoID.Bullet;
			Item.useStyle = 5;
			Item.shootSpeed = 20f;
			Item.knockBack = 15;
			Item.value = 1000000;
			Item.rare = 10;
			Item.shoot = 440;
			Item.shootSpeed = 10f;
			Item.UseSound = SoundID.Item40;
			Item.autoReuse = true;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Las Cannon");
			// Tooltip.SetDefault("Uses bullets as ammo");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 440;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-20, 0);
		}

	}
}
