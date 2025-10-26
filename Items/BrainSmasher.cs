using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Chain;

namespace Tremor.Items
{
	public class BrainSmasher:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 250000;
			Item.rare = 7;
			Item.accessory = true;
			Item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brain Smasher");
			// Tooltip.SetDefault("Grants a spinning ball around the player");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(ModContent.BuffType<Buffs.BrainSmasherBuff>(), 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BallnChain>(), 1);
			recipe.AddIngredient(ModContent.ItemType<GolemCore>(), 1);
			recipe.AddIngredient(2766, 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
