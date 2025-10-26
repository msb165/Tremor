using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class Stynginator:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 49;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 20;
			Item.useAnimation = 20;

			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 6, 0, 0);
			Item.rare = 8;
			Item.crit = 3;
			Item.useStyle = 5;
			Item.UseSound = SoundID.Item36;
			Item.noMelee = true;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.shootSpeed = 16f;
			Item.useAmmo = AmmoID.StyngerBolt;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stynginator");
			// Tooltip.SetDefault("Uses Styngers Bolts as ammo");
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

		public override bool CanConsumeAmmo(Item ammo, Player p)
		{
			return Main.rand.NextBool(2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GolemCore>(), 1);
			recipe.AddIngredient(ItemID.Stynger, 1);
			recipe.AddIngredient(ItemID.Ectoplasm, 18);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
