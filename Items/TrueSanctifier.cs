using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrueSanctifier:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 44;

			item.value = 30000;
			item.rare = 5;
			item.maxStack = 1;
			item.defense = 3;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Sanctifier");
			Tooltip.SetDefault("30% increased alchemical and throwing damage");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.3f;
			player.GetDamage(DamageClass.Throwing) += 0.3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Sanctifier>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroAmulet>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
