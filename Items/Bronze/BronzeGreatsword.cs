using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Bronze
{
	public class BronzeGreatsword:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 11;
			Item.DamageType = DamageClass.Melee;
			Item.width = 42;
			Item.height = 42;
			Item.useTime = 21;
			Item.useAnimation = 21;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 660;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bronze Greatsword");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BronzeBar>(), 15);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
