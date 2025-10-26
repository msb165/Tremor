using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.NovaPillar.Items
{
	public class NovaFragment:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
			Item.height = 48;
			Item.value = 2000;
			Item.rare = 9;
			Item.maxStack = 999;

			ItemID.Sets.ItemIconPulse[Item.type] = true;
			ItemID.Sets.ItemNoGravity[Item.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nova Fragment");
			// Tooltip.SetDefault("'The constituents of stars are contained in this fragment'");
		}

		public override void PostUpdate()
		{
			Lighting.AddLight(Item.Center, new Vector3(0.8f, 0.7f, 0.3f) * Main.essScale);
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3456, 1);
			recipe.AddIngredient(3457, 1);
			recipe.AddIngredient(3458, 1);
			recipe.AddIngredient(3459, 1);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
