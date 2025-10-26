using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Buffs;
using Tremor.Items.Alien;

namespace Tremor.Items
{
	public class GlassPotion:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 32;
			Item.maxStack = 20;
			Item.rare = 11;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 2;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glass Potion");
			// Tooltip.SetDefault("You deal three times more damage, but your defense is reduced to zero.");
		}

		public override bool? UseItem(Player player)
		{
			player.AddBuff(ModContent.BuffType<FragileCondition>(), 14400);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ModContent.ItemType<AtisBlood>(), 1);
			recipe.AddIngredient(ModContent.ItemType<AlienTongue>(), 1);
			recipe.AddIngredient(ModContent.ItemType<SpiderMeat>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.AlchemyStationTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
