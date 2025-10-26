using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Chaos
{
	[AutoloadEquip(EquipType.Body)]
	public class ChaosBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;

			Item.value = 6000;
			Item.rare = 5;
			Item.defense = 13;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chaos Breastplate");
			// Tooltip.SetDefault("Increases movement speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.20f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ChaosBar>(), 22);
			recipe.AddIngredient(ItemID.CrystalShard, 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
