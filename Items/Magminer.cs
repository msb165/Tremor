using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Magmonium;

namespace Tremor.Items
{
	public class Magminer:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 40;
			item.DamageType = DamageClass.Melee;
			item.width = 60;
			item.height = 52;
			item.useTime = 12;
			item.useAnimation = 15;
			item.pick = 200;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 600;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magminer");
			Tooltip.SetDefault("");
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
