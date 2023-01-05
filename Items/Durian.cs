using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Durian:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 18;
			item.DamageType = DamageClass.Magic;
			item.width = 40;
			item.mana = 9;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 3;
			//item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 374;
			item.shootSpeed = 12f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Durian");
			Tooltip.SetDefault("");
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
