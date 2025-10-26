using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Wood
{
	public class WoodenCross:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 8;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 30;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 2;
			Item.value = 2200;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Wooden Cross");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
