using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Megalodon:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.useStyle = 5;
			Item.autoReuse = true;
			Item.useAnimation = 4;
			Item.useTime = 4;

			Item.width = 50;
			Item.height = 18;
			Item.shoot = 10;
			Item.useAmmo = AmmoID.Bullet;
			Item.UseSound = SoundID.Item41;
			Item.damage = 73;
			Item.shootSpeed = 14f;
			Item.noMelee = true;
			Item.value = Item.sellPrice(0, 5, 0, 0);
			Item.rare = 10;

			Item.knockBack = 1.75f;
			Item.DamageType = DamageClass.Ranged;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Megalodon");
			// Tooltip.SetDefault("50% chance not to consume ammo");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-20, 0);
		}

		public override bool CanConsumeAmmo(Item ammo, Player p)
		{
			return Main.rand.NextBool(3);
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
			recipe.AddIngredient(ModContent.ItemType<EyeofOblivion>(), 1);
			recipe.AddIngredient(ItemID.Megashark, 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 20);
			recipe.AddIngredient(ModContent.ItemType<CarbonSteel>(), 10);
			recipe.AddIngredient(ModContent.ItemType<DeadTissue>(), 5);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
