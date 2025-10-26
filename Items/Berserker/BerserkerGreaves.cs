using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items.Berserker
{
	[AutoloadEquip(EquipType.Legs)]
	public class BerserkerGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 500;

			Item.rare = 2;
			Item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Berserker Greaves");
			// Tooltip.SetDefault("4% increased melee damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.04f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 16);
			recipe.AddIngredient(ModContent.ItemType<MinotaurHorn>(), 1);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
