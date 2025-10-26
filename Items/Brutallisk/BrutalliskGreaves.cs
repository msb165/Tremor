using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items.Brutallisk
{
	[AutoloadEquip(EquipType.Legs)]
	public class BrutalliskGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;
			Item.value = 150000;
			Item.rare = 11;
			Item.defense = 20;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brutallisk Greaves");
			/* Tooltip.SetDefault("Increases maximum life by 40\n" +
"15% increased melee speed\n" +
"90% increased movement speed\n" +
"Greatly increases jump height"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.statLifeMax2 += 40;
			player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
			player.moveSpeed += 0.9f;
			player.jumpBoost = true;
			player.jumpSpeedBoost += 0.9f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Aquamarine>(), 8);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 5);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 5);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
