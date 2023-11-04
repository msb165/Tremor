using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tremor.Items
{
	public class NebulaRing:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 28;
			item.height = 22;
			item.value = 250000;
			item.rare = ItemRarityID.Yellow;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nebula Ring ");
			Tooltip.SetDefault("20% increased magic damage\n" +
"Increases magic critical strike chance by 15\n" +
"Increases maximum mana by 80");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.GetDamage(DamageClass.Magic) += 0.2f;
			player.GetCritChance(DamageClass.Magic) += 15;
			player.statManaMax2 += 80;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3457, 10);
			recipe.AddIngredient(3467, 15);
			recipe.AddIngredient(ModContent.ItemType<Band>());
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
