using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EnchantedHealthBooster : ModItem
	{
		public override void SetDefaults()
		{

			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 4;
			item.width = 22;
			item.UseSound = SoundID.Item43;
			item.height = 18;
			item.buffType = ModContent.BuffType<Buffs.ExtendedHealthBooster>();
			item.value = 5160000;
			item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enchanted Health Booster");
			Tooltip.SetDefault("Regenerates heatlh every 45 seconds");
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 2700, true);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
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
