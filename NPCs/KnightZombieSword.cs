using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class KnightZombieSword:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Knight Zombie");
			Main.npcFrameCount[npc.type] = 7;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 40;
			npc.damage = 16;
			npc.defense = 6;
			npc.lifeMax = 140;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 4, 7);
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			AIType = 434;
			npc.npcSlots = 0.5f;
			AnimationType = 434;
		}

		public override void AI()
		{
			if (npc.frame.Y <= 204)
				npc.width = 30;
			if (npc.frame.Y > 204)
				npc.width = 70;
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(25) == 0)
				this.NewItem(ModContent.ItemType<KnightHelmet>());
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/ZombieGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/ZombieGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/KnightZombieGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/ZombieGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/ZombieGore2"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> spawnInfo.SpawnTileY < Main.rockLayer && !Main.dayTime ? 0.01f : 0f;
	}
}
