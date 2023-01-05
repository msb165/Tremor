using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.ZombieEvent.Items;

namespace Tremor.ZombieEvent.Mobs
{

	public class SuperTheHaunt:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Haunt");
			Main.npcFrameCount[npc.type] = 4;
		}

		const int SpeedMulti = 3; 

		public override void SetDefaults()
		{
			npc.lifeMax = 300;
			npc.damage = 84;
			npc.defense = 46;
			npc.knockBackResist = 0.0f;
			npc.width = 42;
			npc.height = 82;
			npc.alpha = 100;
			animationType = 82;
			npc.aiStyle = 22;
			npc.npcSlots = 0.5f;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit52;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 0, 4, 9);
			// banner = npc.type;
			// Todo: bannerItem = ModContent.ItemType<TheHauntBanner>();
		}

		public override void AI()
		{
			if (!NPC.AnyNPCs(ModContent.NPCType<Cryptomage>()))
			{
				npc.Transform(ModContent.NPCType<TheHaunt>());
			}
		}

		public override void NPCLoot()
		{
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + npc.width / 2) / 16;
				int centerY = (int)(npc.position.Y + npc.height / 2) / 16;
				int halfLength = npc.width / 2 / 16 + 1;
				if (Main.rand.NextBool(4))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CursedInk>());
				}
			}
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = npc.lifeMax * 1;
			npc.damage = npc.damage * 1;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(null, npc.position, npc.velocity, 61, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 61, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 62, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 62, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 63, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 63, 1f);
			}
		}

	}
}