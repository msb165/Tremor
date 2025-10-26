using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Chlorophyte;

namespace Tremor.Items
{

	public class Quadratron:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 72;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 12, 5, 0);
			Item.rare = 9;
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
			// DisplayName.SetDefault("Quadratron");
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

		public override bool CanConsumeAmmo(Item ammo, Player p)
		{
			return Main.rand.NextBool(2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GolemCore>(), 1);
			recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
			recipe.AddIngredient(ItemID.TacticalShotgun, 1);
			recipe.AddIngredient(ModContent.ItemType<ChlorophyteDeadshooter>(), 1);
			recipe.AddIngredient(ItemID.SoulofLight, 25);
			recipe.AddIngredient(ItemID.SoulofNight, 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
