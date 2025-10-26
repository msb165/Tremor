using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class UnderratedTrinkets:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 20;
			Item.value = 125000;
			Item.rare = 10;

			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Underrated Trinkets");
			// Tooltip.SetDefault("The less health, the more stats bonuses you gain");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (player.statMana < 25)
			{
				player.statDefense += 10;
			}
			if (player.statMana < 100)
			{
				player.statDefense += 8;
			}
			if (player.statMana < 200)
			{
				player.statDefense += 6;
			}
			if (player.statMana < 300)
			{
				player.statDefense += 3;
			}
			if (player.statLife < 50)
			{
				player.moveSpeed += 1f;
			}
			if (player.statLife < 100)
			{
				player.moveSpeed += 0.9f;
			}
			if (player.statLife < 200)
			{
				player.moveSpeed += 0.7f;
			}
			if (player.statLife < 300)
			{
				player.moveSpeed += 0.5f;
			}
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
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ChaoticCross>(), 1);
			recipe.AddIngredient(ModContent.ItemType<ShroomiteMagicalBoots>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}
	}
}
