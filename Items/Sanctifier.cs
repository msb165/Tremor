using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Sanctifier:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 25000;
			Item.rare = 5;
			Item.maxStack = 1;
			Item.defense = 3;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sanctifier");
			// Tooltip.SetDefault("15% increased alchemical and throwing damage");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.15f;
			player.GetDamage(DamageClass.Throwing) += 0.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.HallowedBar, 16);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}
	}
}
