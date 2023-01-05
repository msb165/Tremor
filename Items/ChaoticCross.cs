using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ChaoticCross:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;

			item.value = 150000;
			item.rare = 6;
			item.accessory = true;
			item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chaotic Cross");
			Tooltip.SetDefault("The less health, the more critical strike chance...\n" +
"The less health, the more damage...");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (player.statLife < 50)
			{
				player.GetCritChance(DamageClass.Generic) += 20;
				player.GetDamage(DamageClass.Generic) += 0.20f;
			}
			if (player.statLife < 100)
			{
				player.GetCritChance(DamageClass.Generic) += 15;
				player.GetDamage(DamageClass.Generic) += 0.15f;
			}
			if (player.statLife < 200)
			{
				player.GetCritChance(DamageClass.Generic) += 10;
				player.GetDamage(DamageClass.Generic) += 0.10f;
			}
			if (player.statLife < 300)
			{
				player.GetCritChance(DamageClass.Generic) += 5;
				player.GetDamage(DamageClass.Generic) += 0.05f;
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<ChaoticAmplifier>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Stigmata>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}
	}
}
