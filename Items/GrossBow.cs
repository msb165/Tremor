using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GrossBow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 23;
			Item.width = 18;
			Item.height = 56;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 30;
			Item.shoot = 1;
			Item.shootSpeed = 12f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 25000;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 3;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gross Bow");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<Projectiles.DemonEyePro>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.DemoniteBar, 5);
			recipe.AddIngredient(ModContent.ItemType<DrippingRoot>(), 12);
			recipe.AddIngredient(ItemID.Lens, 6);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.CrimtaneBar, 5);
			recipe.AddIngredient(ModContent.ItemType<DrippingRoot>(), 12);
			recipe.AddIngredient(ItemID.Lens, 6);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
