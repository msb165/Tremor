using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class LeatherGreaves:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 20;
			Item.value = 200;
			Item.rare = 1;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Leather Greaves");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Leather, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Leather, 15);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(this);
		}
	}
}
