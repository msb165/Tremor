using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class Stormtron:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 63;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 12;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 2100000;
			Item.rare = 10;
			Item.useStyle = 5;
			Item.UseSound = SoundID.Item36;
			Item.noMelee = true;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.shootSpeed = 23f;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stormtron");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i)
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + -2, speedY - 4, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 4, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 3, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 2, speedY - 3, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 3, speedY - 2, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 3, speedY - 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 4, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 4, speedY + 2, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

		public override bool CanConsumeAmmo(Item ammo, Player p)
		{
			return Main.rand.NextBool(2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 22);
			recipe.AddIngredient(ModContent.ItemType<CarbonSteel>(), 15);
			recipe.AddIngredient(ModContent.ItemType<ClusterShard>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
