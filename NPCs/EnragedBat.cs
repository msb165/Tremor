using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class EnragedBat:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Enraged Bat");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1000;
			npc.damage = 110;
			npc.defense = 20;
			npc.knockBackResist = 0.3f;
			npc.width = 56;
			npc.height = 48;
			AnimationType = 93;
			npc.aiStyle = 14;
			npc.npcSlots = 0.2f;
			npc.HitSound = SoundID.NPCHit1;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = Item.buyPrice(0, 0, 6, 9);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<EnragedBatBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 27, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("EnragedGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("EnragedGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("EnragedGore2"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Main.hardMode && NPC.downedMoonlord && !spawnInfo.Player.ZoneDungeon && spawnInfo.SpawnTileY > Main.rockLayer ? 0.1f : 0f;
	}
}