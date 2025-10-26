using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class ShadowMasterChestplate:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 22;
			Item.value = 10000;
			Item.rare = 11;
			Item.defense = 25;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shadow Master Chestplate");
			/* Tooltip.SetDefault("25% increased alchemical damage\n" +
"15% increased throwing damage"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.25f;
			player.GetDamage(DamageClass.Throwing) += 0.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 10);
			recipe.AddIngredient(ModContent.ItemType<DarkGel>(), 15);
			recipe.AddIngredient(ModContent.ItemType<DarknessCloth>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
