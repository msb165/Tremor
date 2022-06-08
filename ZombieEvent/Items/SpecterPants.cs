using Terraria;
using Terraria.ModLoader;
using Tremor.Tiles;

namespace Tremor.ZombieEvent.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class SpecterPants : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 22;

			item.value = 10000;
			item.rare = 11;
			item.defense = 15;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Specter Pants");
			Tooltip.SetDefault("10% increased melee damage\n" +
			                   "10% increased minion damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.1f;
			player.minionDamage += 0.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<CryptStone>(), 5);
			recipe.AddIngredient(ModContent.ItemType<CursedCloth>(), 6);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
