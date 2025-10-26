using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SolarRing:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 22;
			Item.value = 250000;
			Item.rare = 8;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Solar Ring ");
			/* Tooltip.SetDefault("20% increased melee damage\n" +
"Increases melee critical strike chance by 15\n" +
"Casts a ring of fire"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.GetDamage(DamageClass.Melee) += 0.2f;
			player.GetCritChance(DamageClass.Melee) += 15;
			player.AddBuff(116, 60, true);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3458, 10);
			recipe.AddIngredient(3467, 15);
			recipe.AddIngredient(ModContent.ItemType<Band>());
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
