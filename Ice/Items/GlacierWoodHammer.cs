using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class GlacierWoodHammer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 2;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 10;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.hammer = 25;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood Hammer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}

	}
}
