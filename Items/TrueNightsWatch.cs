using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrueNightsWatch:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 10000;
			Item.rare = 4;
			Item.defense = 6;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("True Night's Watch");
			/* Tooltip.SetDefault("12% increased melee, magic, minion, ranged damage and crit\n" +
"Increases maximum mana and health by 80"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Generic) += 0.12f;
			player.statManaMax2 += 80;
			player.statLifeMax2 += 80;
			player.GetCritChance(DamageClass.Generic) += 12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightsWatch>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroAmulet>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}
	}
}
