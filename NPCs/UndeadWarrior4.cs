using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Invar;
using Tremor.ZombieEvent.Items;

namespace Tremor.NPCs
{
	public class UndeadWarrior4:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Relentless Undead Warrior");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = Main.hardMode ? 100 : 80;
			npc.damage = Main.hardMode ? 20 : 40;
			npc.defense = 6;
			npc.knockBackResist = 0.5f;
			npc.width = 36;
			npc.height = 44;
			AnimationType = 21;
			npc.aiStyle = 3;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 3, 7);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<UndeadWarriorBanner>();
		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax += 20 + 10 * numPlayers;
			npc.damage += 2 * numPlayers;
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(10))
				this.NewItem(ModContent.ItemType<BrokenInvarSword>());
			if (Main.rand.NextBool(10))
				this.NewItem(ModContent.ItemType<BrokenInvarShield>());
			if (Main.rand.NextBool(10))
				this.NewItem(ModContent.ItemType<OldInvarPlate>());
			if (Main.rand.NextBool(30))
				this.NewItem(ModContent.ItemType<TornPapyrus>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("UndeadGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("UndeadGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("UndeadWarrior4Gore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("UndeadWarrior4Gore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("UndeadGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("UndeadGore2"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.025f : 0f;
	}
}