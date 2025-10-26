using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PalladiumWarhammer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 41;
			Item.DamageType = DamageClass.Melee;
			Item.width = 38;
			Item.height = 38;
			Item.useTime = 39;
			Item.useAnimation = 39;
			Item.hammer = 80;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 15300;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Palladium Warhammer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.PalladiumBar, 10);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
