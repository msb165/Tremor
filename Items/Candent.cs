using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Candent:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 10000;
			Item.rare = 3;
			Item.defense = 3;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Candent");
			// Tooltip.SetDefault("7% increased melee damage and critical strike chance");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Melee) += 0.07f;
			player.GetCritChance(DamageClass.Melee) += 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 12);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}
	}
}
