using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Desert
{
	public class DesertClaymore:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 60;
			Item.rare = 9;
			Item.expert = true;
			Item.damage = 23;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 20;

			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.value = 270000;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = false;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.DesertClaymorePro>();
			Item.shootSpeed = 0f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Desert Claymore");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(null, position.X, position.Y, 0, 0, type, damage, knockBack, player.whoAmI, player.direction);
			return false;
		}

		public override bool CanUseItem(Player player)
		{
			for (int i = 0; i < Main.projectile.Length; i++)
			{
				if (Main.projectile[i].type == ModContent.ProjectileType<Projectiles.DesertClaymorePro>() && Main.projectile[i].owner == Item.playerIndexTheItemIsReservedFor && Main.projectile[i].active)
				{
					Main.projectile[i].aiStyle = 3;
					return false;
				}
			}
			return true;
		}

	}
}
