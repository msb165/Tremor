using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.Items.Steel;

namespace Tremor.Items.Nightingale
{
	[AutoloadEquip(EquipType.Body)]
	public class NightingaleChestplate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.defense = 7;
			Item.width = 22;
			Item.height = 30;
			Item.value = 3025;
			Item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightingale Chestplate");
			// Tooltip.SetDefault("5% increased damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
