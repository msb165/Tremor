using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Frostbiter:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 86;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 6;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 9;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 128440;
			Item.rare = 8;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 118;
			Item.shootSpeed = 5f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frostbiter");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FrostoneBar>(), 20);
			recipe.AddIngredient(ItemID.Ectoplasm, 12);
			recipe.AddIngredient(ItemID.Lens, 5);
			recipe.AddIngredient(ItemID.SoulofSight, 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int ShotAmt = 2;
			int spread = 5;
			float spreadMult = 0.3f;

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

				Projectile.NewProjectile(null, vector2.X, vector2.Y, vX, vY, 118, damage, knockBack, Main.myPlayer);

			}
			return false;
		}
	}
}
