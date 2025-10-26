using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Souls;

namespace Tremor.NPCs
{
	public class FatFlinx:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fat Flinx");
			Main.npcFrameCount[npc.type] = 12;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 3000;
			npc.damage = 110;
			npc.defense = 45;
			npc.knockBackResist = 0.9f;
			npc.width = 46;
			npc.height = 46;
			AnimationType = 185;
			npc.aiStyle = 3;
			AIType = 166;
			npc.npcSlots = 0.3f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 9, 15);
		}

		public override void NPCLoot()
		{
			if (NPC.downedMoonlord && Main.rand.NextBool(5))
				npc.NewItem(ModContent.ItemType<IceSoul>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1.7f);
				}

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FFGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FFGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FFGore1"), 1f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 2.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Main.hardMode && NPC.downedMoonlord && spawnInfo.Player.ZoneSnow && spawnInfo.SpawnTileY > Main.rockLayer ? 0.1f : 0f;
	}
}