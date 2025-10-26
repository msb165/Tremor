using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Sparks;

namespace Tremor.Items.Alchemist
{
	public class AlchemistFocus:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 22;

			Item.rare = 2;
			Item.accessory = true;
			Item.value = 50000;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Alchemist Focus");
			/* Tooltip.SetDefault("6% increased alchemical damage\n" +
"12% increased alchemical critical strike chance"); */
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 4));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.06f;
			player.GetModPlayer<MPlayer>().alchemicalCrit += 12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AlchemistSpark>());
			recipe.AddIngredient(ModContent.ItemType<GelCube>(), 25);
			recipe.AddIngredient(ItemID.Amethyst, 16);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AltarofEnchantmentsTile>());
			recipe.AddRecipe();
		}
	}
}
