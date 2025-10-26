using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs.Bosses.NovaPillar.Items;

namespace Tremor.Items
{
	public class NovaRing:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.value = 250000;
			Item.rare = 8;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nova Ring");
			/* Tooltip.SetDefault("20% increased alchemical damage\n" +
"14 increased alchemical critical strike chance"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.2f;
			player.GetModPlayer<MPlayer>().alchemicalCrit += 14;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NovaFragment>(), 10);
			recipe.AddIngredient(3467, 15);
			recipe.AddIngredient(ModContent.ItemType<Band>());
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
