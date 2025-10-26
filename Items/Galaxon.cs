using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Galaxon:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 246;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 12;
			Item.width = 42;
			Item.height = 30;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.shoot = 632; //645
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4f;
			Item.value = Item.sellPrice(0, 10, 0, 0);
			Item.rare = 0;
			Item.UseSound = SoundID.Item12;

			Item.autoReuse = true;
			Item.shootSpeed = 25f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Galaxon");
			// Tooltip.SetDefault("Shoots a cosmic beam");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int i = Main.myPlayer;
			float num72 = Item.shootSpeed;
			int num73 = Item.damage;
			float num74 = Item.knockBack;
			num74 = player.GetWeaponKnockback(Item, num74);
			player.itemTime = Item.useTime;
			Vector2 vector2 = player.RotatedRelativePoint(player.MountedCenter, true);
			Vector2 value = Vector2.UnitX.RotatedBy(player.fullRotation, default(Vector2));
			Vector2 vector3 = Main.MouseWorld - vector2;
			float num78 = Main.mouseX + Main.screenPosition.X - vector2.X;
			float num79 = Main.mouseY + Main.screenPosition.Y - vector2.Y;
			if (player.gravDir == -1f)
			{
				num79 = Main.screenPosition.Y + Main.screenHeight - Main.mouseY - vector2.Y;
			}
			float num80 = (float)Math.Sqrt(num78 * num78 + num79 * num79);
			float num81 = num80;
			if ((float.IsNaN(num78) && float.IsNaN(num79)) || (num78 == 0f && num79 == 0f))
			{
				num78 = player.direction;
				num79 = 0f;
				num80 = num72;
			}
			else
			{
				num80 = num72 / num80;
			}
			num78 *= num80;
			num79 *= num80;
			int num146 = 4;
			if (Main.rand.NextBool(2))
			{
				num146++;
			}
			if (Main.rand.NextBool(4))
			{
				num146++;
			}
			if (Main.rand.NextBool(8))
			{
				num146++;
			}
			if (Main.rand.Next(16) == 0)
			{
				num146++;
			}
			for (int num147 = 0; num147 < num146; num147++)
			{
				float num148 = num78;
				float num149 = num79;
				float num150 = 0.05f * num147;
				num148 += Main.rand.Next(-35, 36) * num150;
				num149 += Main.rand.Next(-35, 36) * num150;
				num80 = (float)Math.Sqrt(num148 * num148 + num149 * num149);
				num80 = num72 / num80;
				num148 *= num80;
				num149 *= num80;
				float x4 = vector2.X;
				float y4 = vector2.Y;
				Projectile.NewProjectile(null, x4, y4, num148, num149, ModContent.ProjectileType<Projectiles.GalaxonPro>(), num73, num74, i, 0f, 0f);
			}
			return false;
		}

		public override Vector2? HoldoutOffset()
		{
			return Vector2.Zero;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 16);
			recipe.AddIngredient(ModContent.ItemType<CollapsiumBar>(), 16);
			recipe.AddIngredient(ModContent.ItemType<Blasticyde>(), 16);
			recipe.AddIngredient(ModContent.ItemType<HuskofDusk>(), 16);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}

	}
}
