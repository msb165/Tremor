using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TitaniumWarhammer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 44;
			Item.height = 44;
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.hammer = 86;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 32200;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Titanium Warhammer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TitaniumBar, 13);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
