using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SnakeDevourer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 295;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 58;
			Item.height = 26;
			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;

			Item.useAmmo = AmmoID.Bullet;
			Item.value = 1000000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 440;
			Item.shootSpeed = 6f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Snake Devourer");
			// Tooltip.SetDefault("Uses bullets as ammo");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, -2);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 440;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
}
