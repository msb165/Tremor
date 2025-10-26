using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class JungleWrath:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 44;

			Item.value = 10000;
			Item.rare = 3;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Jungle Wrath");
			// Tooltip.SetDefault("6% increased magic and minion damage");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Magic) += 0.06f;
			player.GetDamage(DamageClass.Summon) += 0.06f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<JungleAlloy>(), 1);
			recipe.AddIngredient(ItemID.JungleSpores, 16);
			recipe.AddIngredient(ItemID.Stinger, 6);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}
	}
}
