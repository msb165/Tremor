using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class Skullker:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Skullker");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 4000;
			npc.damage = 122;
			npc.defense = 90;
			npc.knockBackResist = 0.2f;
			npc.width = 75;
			npc.height = 95;
			AnimationType = 82;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.aiStyle = 22;
			AIType = 82;
			npc.npcSlots = 5f;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath52;
			npc.value = Item.buyPrice(0, 0, 8, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<SkullkerBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 60; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 226, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 226, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 226, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}

				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 226, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				for(int i = 0; i < 3; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"SkullkerGore{i+1}"), 1f);
			}
			else
			{
				for (int k = 0; k < npc.damage / npc.lifeMax * 50; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 226, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.Player.ZoneDungeon && NPC.downedMoonlord && Main.hardMode && spawnInfo.SpawnTileY > Main.rockLayer ? 0.006f : 0f;
	}
}