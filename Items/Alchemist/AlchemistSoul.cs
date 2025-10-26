using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items.Alchemist
{
	public class AlchemistSoul:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 22;

			Item.rare = 3;
			Item.accessory = true;
			Item.value = 100000;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Alchemist Soul");
			/* Tooltip.SetDefault("12% increased alchemical damage\n" +
"15% increased alchemical critical strike chance"); */
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 6));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.12f;
			player.GetModPlayer<MPlayer>().alchemicalCrit += 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AlchemistFocus>());
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 3);
			recipe.AddIngredient(ModContent.ItemType<AlchemistEmblem>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AltarofEnchantmentsTile>());
			recipe.AddRecipe();
		}
	}
}
