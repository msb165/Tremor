using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Buffs;

namespace Tremor.Items
{
	public class BouncingCasing:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 25000;
			Item.rare = 5;
			Item.accessory = true;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bouncing Casing");
			// Tooltip.SetDefault("Alchemical flasks bounce off blocks");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(ModContent.BuffType<BouncingCasingBuff>(), 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddIngredient(ModContent.ItemType<PinkGelCube>(), 5);
			recipe.AddIngredient(ItemID.SoulofLight, 9);
			recipe.AddIngredient(ItemID.SoulofNight, 9);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
