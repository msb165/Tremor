using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class SoulofMind:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 22;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = 5;

			ItemID.Sets.ItemNoGravity[Item.type] = true;
			ItemID.Sets.AnimatesAsSoul[Item.type] = true;
			ItemID.Sets.ItemIconPulse[Item.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Soul of Plight");
			// Tooltip.SetDefault("'The essence of perfect intellect'");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 4));
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.Yellow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SoulofMight, 2);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.RecyclerofMatterTile>());
			recipe.AddRecipe();
		}
	}
}
