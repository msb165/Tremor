using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class SoulEruption:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.mana = 8;
			Item.UseSound = SoundID.Item43;
			Item.useStyle = 5;
			Item.damage = 192;
			Item.autoReuse = true;
			Item.useAnimation = 16;
			Item.useTime = 16;
			Item.width = 40;
			Item.height = 40;
			Item.shoot = 297;
			Item.shootSpeed = 6f;
			Item.knockBack = 6f;
			Item.value = Item.sellPrice(0, 12, 0, 0);
			Item.DamageType = DamageClass.Magic;
			Item.noMelee = true;
			Item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Soul Eruption");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 1, speedY - 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SpectreBar, 20);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 12);
			recipe.AddIngredient(ModContent.ItemType<PurpleQuartz>(), 15);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
