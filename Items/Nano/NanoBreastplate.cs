using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Nano
{
	[AutoloadEquip(EquipType.Body)]
	public class NanoBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 18;

			item.value = 60000;
			item.rare = 6;
			item.defense = 17;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nano Breastplate");
			Tooltip.SetDefault("8% increased damage\n" +
"10% increased melee speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.08f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.10f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<NanoBar>(), 20);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
