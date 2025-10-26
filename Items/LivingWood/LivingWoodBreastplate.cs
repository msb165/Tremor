using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.LivingWood
{
	[AutoloadEquip(EquipType.Body)]
	public class LivingWoodBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 200;
			Item.rare = 1;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Living Wood Breastplate");
			/* Tooltip.SetDefault("4% increased minion damage\n" +
"Increases your max number of minions"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions += 1;
			player.GetDamage(DamageClass.Summon) += 0.04f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 30);
			recipe.SetResult(this);
			recipe.AddTile(304);
			recipe.AddRecipe();
		}

	}
}
