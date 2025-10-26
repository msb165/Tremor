using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TheCreator:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 10000;
			Item.rare = 4;
			Item.defense = 9;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Creator");
			/* Tooltip.SetDefault("15% increased damage and crit\n" +
"Increases maximum mana and health by 100"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Generic) += 0.15f;
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.15f;
			player.statManaMax2 += 100;
			player.statLifeMax2 += 100;
			player.GetCritChance(DamageClass.Generic) += 15;
			player.GetModPlayer<MPlayer>().alchemicalCrit += 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<TrueBloodshed>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TrueSanctifier>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<TrueNightsWatch>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TrueSanctifier>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}
	}
}
