using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class Barmadillo:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Barmadillo");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 12500;
			npc.damage = 120;
			npc.defense = 100;
			npc.knockBackResist = 0.3f;
			npc.width = 100;
			npc.height = 100;
			npc.aiStyle = 2;
			AIType = 180;
			AnimationType = 48;
			npc.aiStyle = 2;
			npc.npcSlots = 0.5f;
			npc.noTileCollide = true;
			npc.buffImmune[20] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[39] = true;
			npc.buffImmune[31] = false;
			npc.HitSound = SoundID.NPCHit1;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath57;
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<BarmadilloBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 44, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("BarmadilloGore4"), 1f);
			}
			else
			{
				for (int k = 0; k < npc.damage / npc.lifeMax * 50; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 44, hit.HitDirection, -1f, 0, default(Color), 0.7f);
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(2))
				npc.NewItem((short)ModContent.ItemType<Blasticyde>(), Main.rand.Next(1, 3));
			if (Main.rand.NextBool())
				npc.NewItem((short)ModContent.ItemType<LapisLazuli>(), Main.rand.Next(2, 4));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return Main.hardMode && TremorWorld.Boss.Trinity.IsDowned() && !spawnInfo.Player.ZoneDungeon && spawnInfo.SpawnTileY > Main.rockLayer ? 0.002f : 0f;
		}
	}
}