using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Antlion;
using Tremor.NPCs;

namespace Tremor.Items.Desert
{
	public class DesertCrown:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 16;
			Item.maxStack = 20;

			Item.rare = 2;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.value = 50000;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Desert Crown");
			/* Tooltip.SetDefault("Summons the Rukh\n" +
"Requires the desert biome"); */
		}

		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(ModContent.NPCType<npcVultureKing>()) && player.ZoneDesert;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<npcVultureKing>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GoldCrown);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 3);
			recipe.AddIngredient(ItemID.SandBlock, 15);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.PlatinumCrown);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 3);
			recipe.AddIngredient(ItemID.SandBlock, 15);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
