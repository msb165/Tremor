using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items.Afterlife
{
	[AutoloadEquip(EquipType.Body)]
	public class AfterlifeBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;

			Item.rare = 6;
			Item.defense = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Afterlife Breastplate");
			/* Tooltip.SetDefault("9% increased damage\n" +
"Increases your max number of minions"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions += 2;
			player.GetDamage(DamageClass.Generic) += 0.09f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SkullTeeth>(), 3);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 20);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
