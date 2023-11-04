using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class LaurelWreath:TremorModItem
	{

		public override void SetDefaults()
		{
			item.width = 26;

			item.height = 24;
			item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Laurel Wreath");
			Tooltip.SetDefault("'The latest fashion trend'");
		}

		//TODO: [Skipped for 1.4] DrawHair
		//public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		//{
		//	drawHair = true;
		//}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Vine, 3);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
