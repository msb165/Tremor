using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Bronze
{
	public class BronzeBow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 10;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 30;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = 1;
			Item.shootSpeed = 12f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 540;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 1;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bronze Bow");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BronzeBar>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
