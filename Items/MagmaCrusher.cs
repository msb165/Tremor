using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Magmonium;

namespace Tremor.Items
{
	public class MagmaCrusher:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 85;
			item.DamageType = DamageClass.Melee;
			item.width = 52;
			item.height = 52;
			item.useTime = 27;
			item.useAnimation = 27;
			item.hammer = 180;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 600;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magma Crusher");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<MagmoniumBar>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
