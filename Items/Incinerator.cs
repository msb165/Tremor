using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{

	public class Incinerator:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 82;
			Item.mana = 12;
			Item.width = 20;
			Item.height = 12;
			Item.DamageType = DamageClass.Magic;
			Item.useTime = 27;
			Item.useAnimation = 27;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 6, 0, 0);
			Item.rare = 8;
			Item.crit = 3;
			Item.useStyle = 5;
			Item.UseSound = SoundID.Item36;
			Item.noMelee = true;
			Item.autoReuse = true;
			Item.shoot = 260;
			Item.shootSpeed = 10f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Incinerator");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 2, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(null, position.X, position.Y, speedX - 1, speedY - 2, type, damage, knockBack, Main.myPlayer);
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
			recipe.AddIngredient(ItemID.HeatRay, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 16);
			recipe.AddIngredient(ItemID.SoulofFright, 16);
			recipe.AddIngredient(ItemID.SoulofSight, 16);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GolemCore>(), 1);
			recipe.AddIngredient(ItemID.HeatRay, 1);
			recipe.AddIngredient(ModContent.ItemType<SoulofMind>(), 16);
			recipe.AddIngredient(ItemID.SoulofFright, 16);
			recipe.AddIngredient(ItemID.SoulofSight, 16);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
