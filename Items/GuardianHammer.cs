using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GuardianHammer:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.noMelee = true;
			Item.useStyle = 1;

			Item.shootSpeed = 14f;
			Item.shoot = ModContent.ProjectileType<Projectiles.GuardianHammerPro>();
			Item.damage = 125;
			Item.knockBack = 9f;
			Item.width = 14;
			Item.height = 28;
			Item.UseSound = SoundID.Item1;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.noUseGraphic = true;
			Item.rare = 11;
			Item.value = Item.sellPrice(0, 20, 0, 0);
			Item.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Guardian Hammer");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 3, speedY + 3, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 3, speedY - 3, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.PaladinsHammer, 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 16);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
