using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Magmonium;

namespace Tremor.Items
{
	public class Magminer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 40;
			Item.DamageType = DamageClass.Melee;
			Item.width = 60;
			Item.height = 52;
			Item.useTime = 12;
			Item.useAnimation = 15;
			Item.pick = 200;
			Item.useStyle = 1;
			Item.knockBack = 2;
			Item.value = 600;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magminer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<MagmoniumBar>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
