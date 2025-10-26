using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class FrostsparkStompers:TremorModItem
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
			// DisplayName.SetDefault("Frostspark Stompers");
			/* Tooltip.SetDefault("10% increased movement speed and increases knockback effect\n" +
"Allows flight, super fast running, and extra mobility on ice"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.accRunSpeed = 6.75f;
			player.rocketBoots = 3;
			player.moveSpeed += 0.1f;
			player.maxRunSpeed += 0.1f;
			player.kbBuff = true;
			player.iceSkate = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(1862, 1);
			recipe.AddIngredient(ModContent.ItemType<RockStompers>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}
	}
}
