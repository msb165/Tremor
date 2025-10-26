using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Cobalt
{
	public class CobaltWarhammer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 38;
			Item.DamageType = DamageClass.Melee;
			Item.width = 44;
			Item.height = 40;
			Item.useTime = 39;
			Item.useAnimation = 39;
			Item.hammer = 80;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 13800;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cobalt Warhammer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
