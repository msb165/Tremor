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
			item.width = 24;
			item.height = 16;
			item.maxStack = 20;

			item.rare = 2;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.value = 50000;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Crown");
			Tooltip.SetDefault("Summons the Rukh\n" +
"Requires the desert biome");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCrown);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 3);
			recipe.AddIngredient(ItemID.SandBlock, 15);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
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
