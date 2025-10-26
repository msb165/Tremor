using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.ZombieEvent.Items;

namespace Tremor.ZombieEvent.Mobs
{
	public class DiceZombie:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dice Zombie");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 300;
			npc.damage = 22;
			npc.defense = 26;
			npc.knockBackResist = 0.3f;
			npc.width = 34;
			npc.height = 46;
			AnimationType = 3;
			npc.aiStyle = 3;
			npc.npcSlots = 2f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 1);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<DiceZombieBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("DeadlingHead1"));
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("DeadlingLeg"));
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("DeadlingArm"));
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("DeadlingLeg"));
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("DeadlingArm"));
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("DiceGore1"));
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("DiceGore2"));
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("DiceGore3"));
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Rupicide>(), Main.rand.Next(1, 3));
			};

			if (Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StoneDice>());
			};
		}
	}
}