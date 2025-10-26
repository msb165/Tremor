using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TungstenBullet:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 10;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.knockBack = 3;
			Item.value = 3;
			Item.rare = 1;
			Item.shoot = 14;
			Item.shootSpeed = 4f;
			Item.shoot = 14;
			Item.ammo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tungsten Bullet");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MusketBall, 70);
			recipe.AddIngredient(ItemID.TungstenBar, 1);
			recipe.SetResult(this, 70);
			recipe.AddRecipe();
		}
	}
}
