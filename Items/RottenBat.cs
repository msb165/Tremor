using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Flesh;

namespace Tremor.Items
{
	public class RottenBat:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 30;

			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 9;
			Item.value = 100;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rotten Bat");
			// Tooltip.SetDefault("'Sewn from pieces of flesh'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<UntreatedFlesh>(), 9);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.FleshWorkstationTile>());
			recipe.AddRecipe();
		}
	}
}
