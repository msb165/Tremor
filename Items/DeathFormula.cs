using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class DeathFormula:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 30000;
			Item.rare = 3;
			Item.maxStack = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Death Formula");
			// Tooltip.SetDefault("20% increased alchemical critical strike chance");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalCrit += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ModContent.ItemType<GelCube>(), 25);
			recipe.AddIngredient(ModContent.ItemType<CursedSoul>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TearsofDeath>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}
	}
}
