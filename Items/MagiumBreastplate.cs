using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class MagiumBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 18000;
			Item.rare = 5;
			Item.defense = 9;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magium Breastplate");
			/* Tooltip.SetDefault("10% increased magic damage\n" +
"Increases maximum mana by 40"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 40;
			player.GetDamage(DamageClass.Magic) += 0.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<RuneBar>(), 12);
			recipe.AddIngredient(ModContent.ItemType<MagiumShard>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

	}
}
