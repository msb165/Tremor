using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightmareBullet:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;

			Item.consumable = true;
			Item.knockBack = 1.5f;
			Item.value = 10;
			Item.rare = 11;
			Item.shoot = ModContent.ProjectileType<Projectiles.NightmareBulletPro>();
			Item.shootSpeed = 10f;
			Item.ammo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightmare Bullet");
			// Tooltip.SetDefault("'Can bounce off blocks.'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.EmptyBullet, 50);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 1);
			recipe.AddTile(412);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
