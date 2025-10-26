using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class IceBullet:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 11;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;

			Item.consumable = true;
			Item.knockBack = 1.5f;
			Item.value = 10;
			Item.rare = 2;
			Item.shoot = ModContent.ProjectileType<Projectiles.IceBullet>();
			Item.shootSpeed = 8f;
			Item.ammo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ice Bullet");
			// Tooltip.SetDefault("25% chance to inflict frostburn");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MusketBall, 100);
			recipe.AddIngredient(ItemID.IceBlock, 30);
			recipe.AddTile(16);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}
