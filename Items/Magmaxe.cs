using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Magmonium;

namespace Tremor.Items
{
	public class Magmaxe:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 65;
			item.DamageType = DamageClass.Melee;
			item.width = 60;
			item.height = 52;
			item.useTime = 32;
			item.useAnimation = 32;
			item.axe = 40;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 600;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magmaxe");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<MagmoniumBar>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
