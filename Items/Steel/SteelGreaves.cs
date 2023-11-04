using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Steel
{
	[AutoloadEquip(EquipType.Legs)]
	public class SteelGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 18;
			item.value = 500;

			item.rare = 1;
			item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Greaves");
			Tooltip.SetDefault("3% increased magic critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Magic) += 3;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<LeatherGreaves>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
