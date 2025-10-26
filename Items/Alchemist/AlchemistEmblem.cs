using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Alchemist
{
	public class AlchemistEmblem:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 28;
			Item.value = 20000;
			Item.rare = 4;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Alchemist Emblem");
			// Tooltip.SetDefault("15% increased alchemical damage");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.15f;
		}

		public override void AddRecipes()
		{
			var recipe = new ModRecipe();
			recipe.AddIngredient(this);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.AvengerEmblem);
			recipe.AddRecipe();
		}
	}
}
