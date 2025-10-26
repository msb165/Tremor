using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class Avenger:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Avenger");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1750;
			npc.damage = 165;
			npc.defense = 80;
			npc.knockBackResist = 0.0f;
			npc.width = 80;
			npc.height = 80;
			AnimationType = 82;
			npc.aiStyle = 97;
			AIType = 420;
			npc.npcSlots = 0.4f;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit4;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 0, 4, 15);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<AvengerBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life > 0)
				Main.dust[Dust.NewDust(npc.position, npc.width, npc.height, 71, 0f, 0f, 200)].velocity *= 1.5F;
			else
			{
				for (int i = 0; i < 50; i++)
				{
					Main.dust[Dust.NewDust(npc.position, npc.width, npc.height, 71, hit.HitDirection, 0f, 200)].velocity *= 1.5f;

					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("AvengerGore1"), 1f);
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("AvengerGore1"), 1f);
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("AvengerGore2"), 1f);
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("AvengerGore2"), 1f);
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("AvengerGore3"), 1f);
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("AvengerGore4"), 1f);
				}
			}
		}

		public override void NPCLoot()
		{			
			if (Main.rand.NextBool(3))
				npc.NewItem((short)ModContent.ItemType<CarbonSteel>(), Main.rand.Next(1, 3));
			if (Main.rand.NextBool(5))
				npc.NewItem((short)ModContent.ItemType<GoldenClaw>(), Main.rand.Next(1, 5));
			if (Main.rand.Next(10) == 0)
				npc.NewItem((short)ModContent.ItemType<AngryShard>(), Main.rand.Next(1, 3));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && NPC.downedMoonlord && Main.hardMode && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.03f : 0f;
		}
	}
}