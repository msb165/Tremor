using Terraria;
using Terraria.ModLoader;
using Tremor.Tiles;

namespace Tremor.ZombieEvent.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class SpecterChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 10000;
			item.rare = 11;
			item.defense = 22;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Specter Chestplate");
			Tooltip.SetDefault("12% increased melee damage\n" +
	  "Increases maximum number of minions by 2");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.2f;
			player.GetDamage(DamageClass.Melee) += 0.12f;
			player.maxMinions += 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<CryptStone>(), 8);
			recipe.AddIngredient(ModContent.ItemType<CursedCloth>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
