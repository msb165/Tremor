using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items.Berserker
{
	[AutoloadEquip(EquipType.Body)]
	public class BerserkerChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;

			Item.value = 600;
			Item.rare = 2;
			Item.defense = 6;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Berserker Chestplate");
			// Tooltip.SetDefault("7% increased melee critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Melee) += 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 20);
			recipe.AddIngredient(ModContent.ItemType<MinotaurHorn>(), 1);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
