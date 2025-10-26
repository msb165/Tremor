using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ChilledBow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 13;
			Item.width = 18;
			Item.height = 56;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 30;
			Item.shoot = 1;
			Item.shootSpeed = 12f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 2500;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 1;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chilled Bow");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FrostCore>(), 9);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
