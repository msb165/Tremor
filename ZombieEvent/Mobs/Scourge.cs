using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.ZombieEvent.Items;

namespace Tremor.ZombieEvent.Mobs
{

	public class Scourge:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Scourge");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 250;
			npc.damage = 60;
			npc.defense = 60;
			npc.knockBackResist = 0.3f;
			npc.width = 56;
			npc.height = 48;
			AnimationType = 429;
			AIType = 429;
			npc.aiStyle = 3;
			npc.npcSlots = 0.2f;
			npc.scale *= 0.8f;
			npc.HitSound = SoundID.NPCHit37;
			npc.DeathSound = SoundID.NPCDeath33;
			npc.value = Item.buyPrice(0, 0, 9, 9);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<ScourgeBanner>();
		}

		public override void AI()
		{
			if (NPC.AnyNPCs(ModContent.NPCType<Cryptomage>()))
			{
				npc.Transform(ModContent.NPCType<SuperScourge>());
			}
		}

		public override void NPCLoot()
		{
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + npc.width / 2) / 16;
				int centerY = (int)(npc.position.Y + npc.height / 2) / 16;
				int halfLength = npc.width / 2 / 16 + 1;
				if (Main.rand.Next(30) == 0 && !WorldGen.crimson)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CursedCleaver>());
				};
				if (Main.rand.Next(30) == 0 && WorldGen.crimson)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IchorCleaver>());
				};
				if (Main.rand.NextBool(3))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CursedCloth>(), Main.rand.Next(1, 3));
				};
			}
		}

		public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
		{
			if (Main.rand.NextBool(5))
			{
				target.AddBuff(39, 600, true);
			}

			if (Main.rand.NextBool(5))
			{
				target.AddBuff(69, 600, true);
			}
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, 99, 0.8f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 0.8f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 0.8f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 0.8f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 0.8f);
			}
		}

	}
}