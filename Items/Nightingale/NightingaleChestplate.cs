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

			item.defense = 7;
			item.width = 22;
			item.height = 30;
			item.value = 3025;
			item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightingale Chestplate");
			Tooltip.SetDefault("5% increased damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
