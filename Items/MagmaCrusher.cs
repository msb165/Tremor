using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Magmonium;

namespace Tremor.Items
{
	public class MagmaCrusher:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 85;
			Item.DamageType = DamageClass.Melee;
			Item.width = 52;
			Item.height = 52;
			Item.useTime = 27;
			Item.useAnimation = 27;
			Item.hammer = 180;
			Item.useStyle = 1;
			Item.knockBack = 8;
			Item.value = 600;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magma Crusher");
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
