using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Argite
{
	[AutoloadEquip(EquipType.Body)]
	public class ArgiteBreastplate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 25000;
			Item.rare = 3;

			Item.defense = 9;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Argite Breastplate");
			// Tooltip.SetDefault("12% increased melee damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.12f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ArgiteBar>(), 22);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
