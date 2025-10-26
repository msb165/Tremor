using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Chain;

namespace Tremor.Items.Alchemist.Chemist
{
	[AutoloadEquip(EquipType.Legs)]
	public class ChemistPants:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 22;
			Item.value = 10000;
			Item.rare = 2;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chemist Pants");
			// Tooltip.SetDefault("6% increased alchemical damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.06f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ChainGreaves>(), 1);
			recipe.AddIngredient(ModContent.ItemType<LeatherGreaves>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}

	}
}
