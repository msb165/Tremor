using Terraria;
using Terraria.ModLoader;
using Tremor.Tiles;

namespace Tremor.ZombieEvent.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class SpecterPants:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 22;

			Item.value = 10000;
			Item.rare = 11;
			Item.defense = 15;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Specter Pants");
			/* Tooltip.SetDefault("10% increased melee damage\n" +
			                   "10% increased minion damage"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.1f;
			player.GetDamage(DamageClass.Summon) += 0.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CryptStone>(), 5);
			recipe.AddIngredient(ModContent.ItemType<CursedCloth>(), 6);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
