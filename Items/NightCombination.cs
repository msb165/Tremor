using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightCombination:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;
			item.value = 50000;
			item.rare = 1;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightly Combination");
			Tooltip.SetDefault("Increases life regeneration, melee damage\n" +
"Makes you glow during night");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (!Main.dayTime)
			{
				player.AddBuff(11, 10);
				player.AddBuff(12, 10);
				player.lifeRegen += 1;
				player.GetDamage(DamageClass.Generic) += 0.1f;
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Bloomstone>());
			recipe.AddIngredient(ModContent.ItemType<DragonGem>());
			recipe.AddIngredient(ModContent.ItemType<TwilightHorns>());
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}
	}
}
