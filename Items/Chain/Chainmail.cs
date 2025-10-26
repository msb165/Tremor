using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Invar;

namespace Tremor.Items.Chain
{
	[AutoloadEquip(EquipType.Body)]
	public class Chainmail:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 18;
			Item.value = Item.sellPrice(silver: 8);
			Item.rare = 1;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chain Mail");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			var recipe = CreateRecipe();
			recipe.AddRecipeGroup(RecipeGroupID.IronBar, 25);
			recipe.AddIngredient(ModContent.ItemType<InvarBar>());
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();//Was missing this
		}
	}
}
