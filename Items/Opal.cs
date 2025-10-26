using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Opal:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.maxStack = 99;
			Item.height = 26;

			Item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Opal");
			// Tooltip.SetDefault("'The king of all gems'");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 6));
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Topaz, 1);
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddIngredient(ItemID.Emerald, 1);
			recipe.AddIngredient(ItemID.Sapphire, 1);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddIngredient(ItemID.Diamond, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
