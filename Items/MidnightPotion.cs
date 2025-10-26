using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Alien;

namespace Tremor.Items
{

	public class MidnightPotion:TremorModItem
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
			// DisplayName.SetDefault("Midnight Potion");
			// Tooltip.SetDefault("Increases all stats during night time");
		}

		public override bool? UseItem(Player player)
		{
			player.AddBuff(ModContent.BuffType<Buffs.NightHunting>(), 14400);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ModContent.ItemType<LapisLazuli>(), 1);
			recipe.AddIngredient(ModContent.ItemType<AlienTongue>(), 1);
			recipe.AddIngredient(ModContent.ItemType<PinkGelCube>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.AlchemyStationTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
