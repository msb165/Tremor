using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Wolf
{
	[AutoloadEquip(EquipType.Legs)]
	public class WolfLeggings:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.rare = 1;

			Item.value = 100;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Wolf Leggings");
			/* Tooltip.SetDefault("6% increased minion damage\n" +
"Increases movement speed"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Summon) += 0.06f;
			player.moveSpeed += 0.10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<WolfPelt>(), 10);
			recipe.AddIngredient(ModContent.ItemType<AlphaClaw>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
