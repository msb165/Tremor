using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Chain;

namespace Tremor.Items.Alchemist.Chemist
{
	[AutoloadEquip(EquipType.Body)]
	public class ChemistJacket:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;

			Item.rare = 2;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chemist Jacket");
			// Tooltip.SetDefault("6% increased alchemical damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.06f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<LeatherShirt>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Chainmail>(), 1);
			recipe.AddIngredient(ModContent.ItemType<HazardousChemicals>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
