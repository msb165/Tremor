using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class GlacierKnives:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 32;
			Item.DamageType = DamageClass.Magic;
			Item.width = 36;
			Item.mana = 11;
			Item.height = 46;

			Item.useTime = 19;
			Item.useAnimation = 19;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			Item.knockBack = 5;
			Item.value = 10000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<GlacierKnivesProj>();
			Item.shootSpeed = 1f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Knives");
			// Tooltip.SetDefault("Spreads out glacier knives");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int ShotAmt = 5;
			int spread = 15;
			float spreadMult = 0.35f;

			Vector2 vector2 = new Vector2();

			for (int i = 0; i < ShotAmt; i++)
			{
				float vX = 8 * speedX + Main.rand.Next(-spread, spread + 1) * spreadMult;
				float vY = 8 * speedY + Main.rand.Next(-spread, spread + 1) * spreadMult;

				float angle = (float)Math.Atan(vY / vX);
				vector2 = new Vector2(position.X + 75f * (float)Math.Cos(angle), position.Y + 75f * (float)Math.Sin(angle));
				float mouseX = Main.mouseX + Main.screenPosition.X;
				if (mouseX < player.position.X)
				{
					vector2 = new Vector2(position.X - 75f * (float)Math.Cos(angle), position.Y - 75f * (float)Math.Sin(angle));
				}

				Projectile.NewProjectile(null, vector2.X, vector2.Y, vX, vY, ModContent.ProjectileType<GlacierKnivesProj>(), damage, knockBack, Main.myPlayer);

			}
			return false;
		}
	}
}
