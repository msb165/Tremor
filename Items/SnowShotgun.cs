using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SnowShotgun:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 17;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 26;
			Item.maxStack = 1;
			Item.height = 56;
			Item.useTime = 32;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 100000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item36;
			Item.autoReuse = false;
			Item.shoot = 166;
			Item.shootSpeed = 10f;
			Item.useAmmo = AmmoID.Snowball;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Snow Shotgun");
			// Tooltip.SetDefault("");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-18, -4);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 1, speedY - 1, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

	}
}
