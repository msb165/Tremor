using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class TheEtherealm:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 100;
			Item.width = 18;
			Item.height = 56;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 17;
			Item.shoot = 1;
			Item.shootSpeed = 52f;
			Item.noMelee = true;
			Item.useAnimation = 17;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 250000;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 11;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Etherealm");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, 440, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, 440, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 1, speedY - 1, 440, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 2, speedY + 2, 440, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 2, speedY - 2, 440, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 3, speedY + 3, 440, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 3, speedY - 3, 440, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

	}
}
