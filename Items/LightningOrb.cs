using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LightningOrb:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 50;
			Item.DamageType = DamageClass.Magic;
			Item.width = 10;
			Item.height = 10;

			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.useStyle = 5;
			Item.UseSound = SoundID.Item81;
			Item.noMelee = true;
			Item.knockBack = 1;
			Item.value = 10000;
			Item.rare = 5;
			Item.autoReuse = false;
			Item.shoot = 580;
			Item.shootSpeed = 7f;
			Item.mana = 30;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Lightning Orb");
			// Tooltip.SetDefault("Creates a divine lightning");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 vector82 = -Main.LocalPlayer.Center + Main.MouseWorld;
			float ai = Main.rand.Next(100);
			Vector2 vector83 = Vector2.Normalize(vector82) * Item.shootSpeed;
			Projectile.NewProjectile(null, player.Center.X, player.Center.Y, vector83.X, vector83.Y, type, damage, .5f, player.whoAmI, vector82.ToRotation(), ai);
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Glass, 30);
			recipe.AddIngredient(ModContent.ItemType<AirFragment>(), 16);
			recipe.AddIngredient(ItemID.SoulofLight, 12);
			recipe.AddIngredient(ItemID.SoulofNight, 12);
			recipe.AddIngredient(ItemID.Diamond, 15);
			recipe.AddIngredient(ItemID.RainCloud, 25);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
