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
			item.width = 30;
			item.height = 18;
			item.value = Item.sellPrice(silver: 8);
			item.rare = 1;
			item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chain Mail");
			Tooltip.SetDefault("");
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
