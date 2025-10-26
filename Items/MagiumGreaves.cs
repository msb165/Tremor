using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class MagiumGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 18000;
			Item.rare = 5;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magium Greaves");
			/* Tooltip.SetDefault("25% increased movement speed\n" +
"Increases maximum mana by 40"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.2f;
			player.maxRunSpeed += 0.2f;
			player.statManaMax2 += 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<RuneBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<MagiumShard>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

	}
}
