using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HellStorm:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 220;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 32;
			Item.height = 78;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			Item.channel = true;
			Item.knockBack = 5f;
			Item.value = 10000000;
			Item.rare = 0;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.HellStormProj>();
			Item.shootSpeed = 20f;

			Item.useAmmo = AmmoID.Arrow;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hell Storm");
			/* Tooltip.SetDefault("Shoots out homing hell arrows\n" +
"The amount of arrows shot increases when used for longer time"); */
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}
		/*
				public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
				{
					Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, ModContent.ProjectileType<Projectiles.HellStormProj>(), damage, knockBack, player.whoAmI, 0.0f, 0.0f);
					return false;
				}
		*/

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<Projectiles.HellStormProj>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

	}
}
