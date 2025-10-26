using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs
{
	[AutoloadBossHead]

	public class TheDarkEmperor:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Dark Emperor");
			Main.npcFrameCount[npc.type] = 14;
		}

		public override void SetDefaults()
		{
			npc.width = 126;
			npc.height = 106;
			npc.damage = 200;
			npc.defense = 170;
			npc.lifeMax = 100000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 80000f;
			npc.knockBackResist = 0.0f;
			Music = 17;
			npc.aiStyle = 87;
			AIType = 475;
			AnimationType = 473;
			npc.npcSlots = 10f;
			npc.buffImmune[20] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[39] = true;
		}

		public override void AI()
		{
			if (Main.rand.Next(500) == 0)
			{
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<DarkServant>());
			}
			if (Main.rand.Next(150) == 0)
			{
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<DarkSlime>());
			}

		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax = npc.lifeMax * 1;
			npc.damage = npc.damage * 1;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 60; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 191, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 191, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 191, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				SoundEngine.PlaySound(SoundID.Roar);
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<TheDarkEmperorTwo>());
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<DarkServant>());
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<DarkServant>());
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<DarkServant>());
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<DarkServant>());
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<DarkServant>());
				Gore.NewGore(null, npc.position, npc.velocity, 99, 3f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 2f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 3f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 2f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 2f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 4f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 2f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 2f);
			}
			else
			{

				for (int k = 0; k < npc.damage / npc.lifeMax * 50.0; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 191, hit.HitDirection, -2f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 191, hit.HitDirection, -1f, 0, default(Color), 0.7f);
				}
			}
		}

	}
}