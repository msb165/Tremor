using System.Linq;

using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class RuinGhost2:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ruin Ghost");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.width = 24;
			npc.height = 46;
			npc.damage = 6;
			npc.defense = 10;
			npc.npcSlots = 1;
			npc.lifeMax = 105;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 100;
			npc.knockBackResist = 0.3f;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.aiStyle = 22;
			aiType = NPCID.Wraith;
			animationType = NPCID.Wraith;
			npc.stepSpeed = .5f;
			npc.lavaImmune = true;
		}

		public override void AI()
		{
			if (Main.rand.Next(700) == 0)
				SoundEngine.PlaySound(SoundID.Zombie1, npc.position);//Variant Main.rand.Next(81, 84)
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(6))
				this.NewItem(ModContent.ItemType<RuinKey>(), 1);
			if (Main.rand.NextBool(6))
				this.NewItem(ModContent.ItemType<RustyLantern>(), 1);
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(null, npc.position, npc.velocity, 13);
				Gore.NewGore(null, npc.position, npc.velocity, 12);
				Gore.NewGore(null, npc.position, npc.velocity, 11);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			int[] TileArray2 = { ModContent.TileType<Tiles.RuinAltar>(), ModContent.TileType<Tiles.RuinChest>(), 120 };
			return TileArray2.Contains(Main.tile[spawnInfo.SpawnTileX, spawnInfo.SpawnTileY].TileType) && TremorWorld.Boss.TikiTotem.IsDowned() ? 45f : 0f;
		}
	}
}