using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Flesh
{
	[AutoloadEquip(EquipType.Legs)]
	public class FleshGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 18000;
			Item.rare = 1;
			Item.defense = 7;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flesh Greaves");
			/* Tooltip.SetDefault("5% increased minion damage\n" +
"Increases your max number of minions"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions += 1;
			player.GetDamage(DamageClass.Summon) += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<PieceofFlesh>(), 6);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

	}
}
