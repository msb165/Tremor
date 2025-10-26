using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Fungus
{
	[AutoloadEquip(EquipType.Body)]
	public class FungusBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 18;
			Item.value = 50000;

			Item.rare = 3;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fungus Breastplate");
			// Tooltip.SetDefault("13% increased damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.13f;
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.13f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FungusElement>(), 18);
			recipe.AddIngredient(ItemID.GlowingMushroom, 15);
			recipe.AddIngredient(ItemID.GoldChainmail, 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FungusElement>(), 18);
			recipe.AddIngredient(ItemID.GlowingMushroom, 15);
			recipe.AddIngredient(ItemID.PlatinumChainmail, 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
