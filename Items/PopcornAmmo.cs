using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PopcornAmmo:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 15;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 22;
			Item.height = 22;
			Item.maxStack = 999;

			Item.consumable = true;
			Item.knockBack = 1.5f;
			Item.value = 10;
			Item.rare = 2;
			Item.shoot = ModContent.ProjectileType<Projectiles.PopcornAmmo>();
			Item.ammo = Item.type;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Popcorn");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Corn>(), 1);
			recipe.SetResult(this, 25);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
