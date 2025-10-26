using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class EvolvedZombie2:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Evolved Zombie");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1000;
			npc.damage = 110;
			npc.defense = 7;
			npc.knockBackResist = 0.3f;
			npc.width = 34;
			npc.height = 46;
			AnimationType = 525;
			npc.aiStyle = 3;
			AIType = 525;
			npc.npcSlots = 0.3f;
			npc.HitSound = SoundID.NPCHit37;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 6, 7);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<EvolvedZombieBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(2))
				npc.NewItem(ModContent.ItemType<ConcentratedEther>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("EvolvGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("EvolvGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("EvolvGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("EvolvGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("EvolvGore4"), 1f);
				Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, Color.White, 3f);
				Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, Color.White, 2f);
				Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, Color.White, 3f);
			}
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && NPC.downedMoonlord && Main.hardMode && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.03f : 0f;
	}
}