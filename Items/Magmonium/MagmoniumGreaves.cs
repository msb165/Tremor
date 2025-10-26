using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Magmonium
{
	[AutoloadEquip(EquipType.Legs)]
	public class MagmoniumGreaves:TremorModItem
	{

		public override void SetDefaults()
		{
			Item.defense = 15;
			Item.width = 22;
			Item.height = 18;
			Item.value = 2500;
			Item.rare = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magmonium Greaves");
			/* Tooltip.SetDefault("10% increased melee speed\n" +
"10% reduced mana usage"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.manaCost -= 0.1f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<MagmoniumBar>(), 20);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
