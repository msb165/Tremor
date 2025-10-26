using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs;
using Tremor.ZombieEvent.Items;

namespace Tremor.Items
{
	public class StoneofKnowledge : TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 30;
			Item.maxStack = 1;

			Item.rare = 12;
			Item.maxStack = 20;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.UseSound = SoundID.Item44;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stone of Knowledge");
			/* Tooltip.SetDefault("Summons the Trinity\n" +
"Requires any mech. boss to have been slain, hardmode and night time"); */
		}

		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime && Main.hardMode && NPC.downedMechBossAny && !NPC.AnyNPCs(ModContent.NPCType<SoulofHope>()) && !NPC.AnyNPCs(ModContent.NPCType<SoulofTrust>()) && !NPC.AnyNPCs(ModContent.NPCType<SoulofTruth>());
		}
		public override bool? UseItem(Player player)
		{
			Main.NewText("The Trinity has awoken!", 175, 75, 255);
			Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[15], player.position);//Variant 0
			if (Main.netMode != 1)
			{
				int b1ID = NPC.NewNPC(null, (int)player.Center.X - 300, (int)player.Center.Y - 800, ModContent.NPCType<SoulofHope>());
				int b2ID = NPC.NewNPC(null, (int)player.Center.X, (int)player.Center.Y - 300, ModContent.NPCType<SoulofTrust>());
				int b3ID = NPC.NewNPC(null, (int)player.Center.X + 100, (int)player.Center.Y - 500, ModContent.NPCType<SoulofTruth>());
				Main.npc[b1ID].ai[2] = b2ID;
				Main.npc[b1ID].ai[3] = b3ID;
				Main.npc[b2ID].ai[2] = b1ID;
				Main.npc[b2ID].ai[3] = b3ID;
				Main.npc[b3ID].ai[2] = b1ID;
				Main.npc[b3ID].ai[3] = b2ID;
			}
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3467, 20);
			recipe.AddIngredient(ModContent.ItemType<StoneDice>(), 1);
			recipe.AddIngredient(ItemID.CelestialSigil, 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<EyeofOblivion>(), 6);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 12);
			recipe.AddIngredient(ItemID.Topaz, 5);
			recipe.AddIngredient(ItemID.Ruby, 5);
			recipe.AddIngredient(ItemID.Emerald, 5);
			recipe.AddIngredient(ModContent.ItemType<CarbonSteel>(), 6);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 5);
			recipe.AddIngredient(ModContent.ItemType<CosmicFuel>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}

	}
}
