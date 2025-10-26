using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Chaos
{
	[AutoloadEquip(EquipType.Legs)]
	public class ChaosGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 6000;

			Item.rare = 5;
			Item.defense = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chaos Greaves");
			/* Tooltip.SetDefault("Increased life max by 25\n" +
"Increased wing time"); */
		}

		public override void UpdateEquip(Player p)
		{
			p.wingTime += 0.15f;
			p.statLifeMax2 += 25;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ChaosBar>(), 17);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
