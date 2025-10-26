using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Angelite;
using Tremor.NPCs.Bosses.AndasBoss;

namespace Tremor.Items
{
	public class InfernoSkull:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 28;
			Item.maxStack = 20;
			Item.value = 100;
			Item.rare = 0;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 4;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Inferno Skull");
			/* Tooltip.SetDefault("Summons the Andas\n" +
"Requires the hell biome and The Trinity to have been downed"); */
		}

		public override bool CanUseItem(Player player)
		{
			return player.position.Y / 16f > Main.maxTilesY - 200 && TremorWorld.Boss.Trinity.IsDowned() && !NPC.AnyNPCs(ModContent.NPCType<Andas>());
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AngeliteBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<CollapsiumBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 12);
			recipe.AddIngredient(ItemID.HellstoneBar, 6);
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddIngredient(ItemID.SoulofNight, 8);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.AddRecipe();
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Andas>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}
	}
}
