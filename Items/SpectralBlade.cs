using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SpectralBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 92;
			Item.DamageType = DamageClass.Melee;
			Item.width = 42;
			Item.height = 46;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = 297;
			Item.shootSpeed = 15f;
			Item.useStyle = 1;
			Item.knockBack = 2;
			Item.value = 46000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Spectral Blade");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SpectreBar, 18);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
