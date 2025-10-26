using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MoonFlash:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 90;
			//Item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 25;
			Item.mana = 10;
			Item.useAnimation = 25;
			Item.useStyle = 5;
			Item.shoot = 645;
			Item.shootSpeed = 40f;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 30, 0, 0);
			Item.rare = 11;
			Item.UseSound = SoundID.Item77;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Moon Flash");
			// Tooltip.SetDefault("");
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

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ModContent.ItemType<LunarRoot>(), 6);
			recipe.AddIngredient(3467, 30);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
