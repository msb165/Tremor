using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class ParatrooperShotgun:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 300;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 46;
			Item.height = 28;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 651000;
			Item.rare = 11;
			Item.useStyle = 5;
			Item.UseSound = SoundID.Item36;
			Item.noMelee = true;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.shootSpeed = 23f;
			Item.useAmmo = AmmoID.Bullet;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paratrooper Shotgun");
			// Tooltip.SetDefault("Has 33% chance not to consume ammo");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
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

		public override bool CanConsumeAmmo(Item ammo, Player p)
		{
			return Main.rand.NextBool(3);
		}
	}
}
