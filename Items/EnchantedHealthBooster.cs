using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EnchantedHealthBooster:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 4;
			Item.width = 22;
			Item.UseSound = SoundID.Item43;
			Item.height = 18;
			Item.buffType = ModContent.BuffType<Buffs.ExtendedHealthBooster>();
			Item.value = 5160000;
			Item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Enchanted Health Booster");
			// Tooltip.SetDefault("Regenerates heatlh every 45 seconds");
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(Item.buffType, 2700, true);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<HealthBooster>(), 1);
			recipe.AddIngredient(ModContent.ItemType<GoldenClaw>(), 15);
			recipe.AddIngredient(ModContent.ItemType<StarBar>(), 1);
			recipe.AddIngredient(ModContent.ItemType<AngryShard>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
