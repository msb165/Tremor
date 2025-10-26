using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.Items.Steel;

namespace Tremor.Items.Nightingale
{
	[AutoloadEquip(EquipType.Legs)]
	public class NightingaleGreaves:TremorModItem
	{

		public override void SetDefaults()
		{
			Item.defense = 6;
			Item.width = 22;
			Item.height = 18;
			Item.value = 2500;
			Item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightingale Greaves");
			// Tooltip.SetDefault("10% increased movement speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.10f;
			player.maxRunSpeed += 0.10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
