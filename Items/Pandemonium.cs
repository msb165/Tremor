using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Pandemonium:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 320;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 52;
			Item.height = 34;
			Item.useTime = 3;
			Item.useAnimation = 12;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4f;
			Item.value = 600000;
			Item.rare = 0;
			Item.UseSound = SoundID.Item92;
			Item.autoReuse = false;
			Item.shootSpeed = 25f;
			Item.shoot = ModContent.ProjectileType<Projectiles.PandemoniumBullet>();
			Item.useAmmo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Pandemonium");
			/* Tooltip.SetDefault("Shoots a burst of bullets\n" +
"Bullets explode into firebals\n" +
"75% chance not to consume ammo"); */
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
		{
			if (Main.rand.Next(0, 100) <= 75)
				return false;
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float SpeedX = speedX + Main.rand.Next(-15, 16) * 0.05f;
			float SpeedY = speedY + Main.rand.Next(-15, 16) * 0.05f;
			Projectile.NewProjectile(null, position.X, position.Y, SpeedX, SpeedY, type, damage, knockBack, player.whoAmI, 0.0f, 0.0f);
			if (Main.rand.NextBool(2))
				Projectile.NewProjectile(null, position.X, position.Y, SpeedX, SpeedY, ModContent.ProjectileType<Projectiles.PandemoniumBullet>(), damage, knockBack, player.whoAmI, 0.0f, 0.0f);
			return false;
		}
	}
}
