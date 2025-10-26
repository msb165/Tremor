using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.MagicalArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class MagicalRobe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 250;

			Item.height = 28;
			Item.value = 600;
			Item.rare = 1;
			Item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Theurgic Mantle");
			/* Tooltip.SetDefault("4% increased magic damage\n" +
"Increases maximum mana by 20"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Magic) += 0.04f;
			player.statManaMax2 += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Silk, 14);
			recipe.AddIngredient(ItemID.LeadBar, 6);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Silk, 14);
			recipe.AddIngredient(ItemID.IronBar, 6);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}

	}
}
