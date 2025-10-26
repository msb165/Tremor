using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Invar;

namespace Tremor.Items.Chain
{
	[AutoloadEquip(EquipType.Head)]
	public class ChainCoif:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 24;
			Item.value = Item.sellPrice(silver: 10);
			Item.rare = 1;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chain Coif");
			// Tooltip.SetDefault("");
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<Chainmail>() && legs.type == ModContent.ItemType<ChainGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+1 defense";
			player.statDefense += 1;
		}

		public override void AddRecipes()
		{
			var recipe = CreateRecipe();
			recipe.AddRecipeGroup(RecipeGroupID.IronBar, 15);
			recipe.AddIngredient(ModContent.ItemType<InvarBar>());
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();//Was missing this
		}
	}
}
