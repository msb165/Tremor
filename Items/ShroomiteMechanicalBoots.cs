using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ShroomiteMechanicalBoots:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 36;
			Item.height = 38;
			Item.value = 110;
			Item.rare = 8;

			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shroomite Mechanical Boots");
			// Tooltip.SetDefault("The less health, the more speed...");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (player.statLife < 50)
			{
				player.moveSpeed += 1f;
			}
			if (player.statLife < 100)
			{
				player.moveSpeed += 0.9f;
			}
			if (player.statLife < 200)
			{
				player.moveSpeed += 0.7f;
			}
			if (player.statLife < 300)
			{
				player.moveSpeed += 0.5f;
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.ShroomiteBar, 22);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
