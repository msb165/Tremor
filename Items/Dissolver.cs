using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Dissolver:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(3279);

			Item.damage = 58;
			Item.width = 30;
			Item.height = 26;
			Item.shoot = ModContent.ProjectileType<Projectiles.DissolverPro>();
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dissolver");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3290, 1);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			recipe.AddIngredient(ItemID.Ichor, 18);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
