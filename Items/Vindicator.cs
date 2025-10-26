using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class Vindicator:TremorModItem
	{

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Vindicator");
			// Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			Item.damage = 200;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 76;
			Item.height = 26;
			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(15, 00);
			Item.rare = 11;
			//Item.UseSound = SoundID.Item23;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.VindicatorProj>();
			Item.shootSpeed = 45f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CarbonSteel>(), 15);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 18);
			recipe.AddIngredient(ItemID.IllegalGunParts, 3);
			recipe.AddIngredient(ItemID.LaserMachinegun, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 8);
			recipe.AddIngredient(ModContent.ItemType<MultidimensionalFragment>(), 9);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, -7);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0.0f, 0.0f);
			return false;
		}
	}
}