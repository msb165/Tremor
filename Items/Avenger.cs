using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items
{
	public class Avenger:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(3279);
			Item.damage = 17;
			Item.width = 30;
			Item.height = 26;
			Item.shoot = ModContent.ProjectileType<Projectiles.AvengerPro>();
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Avenger");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 18);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
