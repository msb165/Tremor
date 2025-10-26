using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.ZombieEvent.Items;

namespace Tremor.ZombieEvent.Mobs
{

	public class Zombeast:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zombeast");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 500;
			npc.damage = 30;
			npc.defense = 12;
			npc.knockBackResist = 0.4f;
			npc.width = 56;
			npc.height = 48;
			AIType = 429;
			AnimationType = 429;
			npc.aiStyle = 3;
			npc.npcSlots = 0.2f;
			npc.HitSound = SoundID.NPCHit37;
			npc.DeathSound = SoundID.NPCDeath57;
			npc.value = Item.buyPrice(0, 0, 6, 9);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<ZombeastBanner>();
		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax = npc.lifeMax * 1;
			npc.damage = npc.damage * 1;
		}

		public override void NPCLoot()
		{
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + npc.width / 2) / 16;
				int centerY = (int)(npc.position.Y + npc.height / 2) / 16;
				int halfLength = npc.width / 2 / 16 + 1;
				if (Main.rand.NextBool())
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WickedHeart>());
				}
				//if (Main.rand.Next(30) == 0)
				//{
				//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Zombeast>());
				//}
			}
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.8f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombeastGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombeastGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombeastGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombeastGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombeastGore3"), 1f);
				Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1f);
				Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 2f);
				Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1f);

			}
		}
	}
}