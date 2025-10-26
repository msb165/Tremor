using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Bloodshed:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 10000;
			Item.rare = 3;
			Item.defense = 6;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bloodshed");
			/* Tooltip.SetDefault("8% increased melee, magic and minion damage\n" +
"Increases maximum mana and health by 60\n" +
"10% increased melee and magic critical strike chance"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Magic) += 0.08f;
			player.GetDamage(DamageClass.Summon) += 0.08f;
			player.GetDamage(DamageClass.Melee) += 0.08f;
			player.statManaMax2 += 60;
			player.statLifeMax2 += 60;
			player.GetCritChance(DamageClass.Melee) += 10;
			player.GetCritChance(DamageClass.Magic) += 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<JungleWrath>(), 1);
			recipe.AddIngredient(ModContent.ItemType<CrimtaneProtector>(), 1);
			recipe.AddIngredient(ModContent.ItemType<WaterStorm>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Candent>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}
	}
}
