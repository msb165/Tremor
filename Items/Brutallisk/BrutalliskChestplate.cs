using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items.Brutallisk
{
	[AutoloadEquip(EquipType.Body)]
	public class BrutalliskChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;
			item.value = 150000;
			item.rare = 11;
			item.defense = 32;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brutallisk Chestplate");
			Tooltip.SetDefault("Increases maximum life by 40\n" +
"15% increased melee speed\n" +
"25% increased damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.statLifeMax2 += 40;
			player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
			player.GetDamage(DamageClass.Generic) += 0.25f;
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.25f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Aquamarine>(), 10);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 6);
			recipe.AddIngredient(ModContent.ItemType<EvershinyBar>(), 8);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 2);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
