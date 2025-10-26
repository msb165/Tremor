using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Wolf
{
	public class WolfClaws:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 9;
			Item.DamageType = DamageClass.Melee;
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 660;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Wolf Claws");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<WolfPelt>(), 13);
			recipe.AddIngredient(ModContent.ItemType<AlphaClaw>(), 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
