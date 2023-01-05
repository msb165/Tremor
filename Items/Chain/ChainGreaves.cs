using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Invar;

namespace Tremor.Items.Chain
{
	[AutoloadEquip(EquipType.Legs)]
	public class ChainGreaves:TremorModItem
	{
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 14;
			item.value = Item.sellPrice(silver: 6);
			item.rare = 1;
			item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chain Greaves");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			var recipe = CreateRecipe();
			recipe.AddRecipeGroup(RecipeGroupID.IronBar, 20);
			recipe.AddIngredient(ModContent.ItemType<InvarBar>());
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();//Was missing this
		}
	}
}
