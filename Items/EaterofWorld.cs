using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class EaterofWorld:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 139;
			item.DamageType = DamageClass.Throwing;
			item.width = 40;
			item.height = 20;
			item.noUseGraphic = true;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 6;
			item.DamageType = DamageClass.Melee;
			item.value = 50000;
			item.rare = 9;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 306;
			item.shootSpeed = 9f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eater of World");
			Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 1, speedY - 1, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<PurpleQuartz>(), 6);
			recipe.AddIngredient(ItemID.DemoniteBar, 25);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 6);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
