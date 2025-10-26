using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RockStompers:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 20;
			Item.value = 110000;
			Item.rare = 3;

			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rock Stompers");
			// Tooltip.SetDefault("Increases your knockback effect");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.kbBuff = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 25);
			recipe.AddIngredient(ItemID.Leather, 10);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
