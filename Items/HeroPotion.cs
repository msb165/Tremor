using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class HeroPotion:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 32;
			Item.maxStack = 20;
			Item.rare = 0;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 2;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hero Potion");
			/* Tooltip.SetDefault("Grants 10000 defense\n" +
"Grants immunity to all debuffs\n" +
"Increases movement speed\n" +
"Makes you priority target for enemies\n" +
"'Feel like a real hero! At least for 15 seconds.'"); */
		}

		public override bool? UseItem(Player player)
		{
			player.AddBuff(ModContent.BuffType<Buffs.HeroBuff>(), 900);
			return true;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ModContent.ItemType<MultidimensionalFragment>(), 10);
			recipe.AddIngredient(ModContent.ItemType<NightmareOre>(), 25);
			recipe.AddIngredient(ItemID.RegenerationPotion, 5);
			recipe.AddIngredient(ItemID.IronskinPotion, 5);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 5);
			recipe.AddIngredient(ItemID.ObsidianSkinPotion, 5);
			recipe.AddIngredient(3456, 5);
			recipe.AddIngredient(3457, 5);
			recipe.AddIngredient(3458, 5);
			recipe.AddIngredient(3459, 5);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.AlchemyStationTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
