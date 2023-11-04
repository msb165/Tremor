using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Dark
{
	[AutoloadEquip(EquipType.Legs)]
	public class DarknessLeggings:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 18;
			item.value = 600000;

			item.rare = 11;
			item.defense = 25;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leggings of Darkness");
			Tooltip.SetDefault("Increases life regeneration");
		}

		public override void UpdateEquip(Player player)
		{
			player.lifeRegen += 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DarkGel>(), 45);
			recipe.AddIngredient(ModContent.ItemType<DarkMatter>(), 45);
			recipe.AddIngredient(ModContent.ItemType<DarkMass>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(247);
			recipe.AddRecipe();
		}
	}
}
