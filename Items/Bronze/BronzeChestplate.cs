using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Bronze
{
	[AutoloadEquip(EquipType.Body)]
	public class BronzeChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;

			Item.value = 600;
			Item.rare = 1;
			Item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bronze Chestplate");
			// Tooltip.SetDefault("6% increased ranged critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Ranged) += 6;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BronzeBar>(), 22);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
