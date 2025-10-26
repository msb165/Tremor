using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Magmonium;

namespace Tremor.Items
{
	public class Magmaxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 65;
			Item.DamageType = DamageClass.Melee;
			Item.width = 60;
			Item.height = 52;
			Item.useTime = 32;
			Item.useAnimation = 32;
			Item.axe = 40;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 600;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magmaxe");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<MagmoniumBar>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
