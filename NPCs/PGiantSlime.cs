using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Tremor.NPCs
{
	public class PGiantSlime:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Purple Slime");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 700;
			npc.damage = 100;
			npc.defense = 30;
			npc.knockBackResist = 0.3f;
			npc.width = 70;
			npc.alpha = 175;
			npc.color = new Color(200, 0, 255, 150);
			npc.height = 46;
			AnimationType = 244;
			npc.aiStyle = 1;
			AIType = 138;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 12, 15);
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
				this.NewItem(23);
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Purple, 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Purple, 0.7f);
				}
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Purple, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Purple, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Purple, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 1, 2.5f * hit.HitDirection, -2.5f, 0, Color.Purple, 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> spawnInfo.SpawnTileY < Main.rockLayer && Main.hardMode && Helper.NoInvasion(spawnInfo) && NPC.downedMoonlord && Main.dayTime ? 0.02f : 0f;
	}
}