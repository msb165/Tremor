using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class SnowmanBomber:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Snowman Bomber");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 400;
			npc.damage = 60;
			npc.defense = 15;
			npc.knockBackResist = 0.1f;
			npc.width = 34;
			npc.height = 46;
			AnimationType = 293;
			npc.aiStyle = 3;
			AIType = 293;
			npc.npcSlots = 0.3f;
			npc.HitSound = SoundID.NPCHit11;
			npc.DeathSound = SoundID.NPCDeath38;
			npc.value = Item.buyPrice(0, 0, 4, 7);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<SnowmanBomberBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1f);

				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 3f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 2f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 3f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> NPC.AnyNPCs(NPCID.MisterStabby) && Main.hardMode && spawnInfo.SpawnTileY < Main.worldSurface ? 0.08f : 0f;
	}
}