using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class ShadowMasterPants:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 10000;
			item.rare = 11;
			item.defense = 20;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Master Pants");
			Tooltip.SetDefault("25% increased alchemical damage\n" +
"15% increased throwing damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.25f;
			player.GetDamage(DamageClass.Throwing) += 0.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 10);
			recipe.AddIngredient(ModContent.ItemType<DarkGel>(), 12);
			recipe.AddIngredient(ModContent.ItemType<DarknessCloth>(), 7);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}

	}
}
