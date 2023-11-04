using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Tremor.Items;
using Tremor.Items.Doom;

namespace Tremor.NPCs
{
	public class Dranix:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dranix");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1600;
			npc.damage = 110;
			npc.defense = 20;
			npc.knockBackResist = 0.3f;
			npc.width = 56;
			npc.height = 48;
			AIType = 429;
			AnimationType = 429;
			npc.aiStyle = 3;
			npc.npcSlots = 0.2f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 6, 9);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<DranixBanner>();
		}

		public override void AI()
		{
			if (Main.rand.Next(1000) == 0)
				Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[22], npc.position);//Variant 1
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(2))
				npc.NewItem(ModContent.ItemType<Doomstone>());
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 74, 2.5f * hitDirection, -2.5f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/DranixGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/DranixGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/DranixGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/DranixGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/DranixGore3"), 1f);

			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Main.hardMode && NPC.downedMoonlord && !spawnInfo.Player.ZoneDungeon && spawnInfo.SpawnTileY > Main.rockLayer ? 0.04f : 0f;
	}
}