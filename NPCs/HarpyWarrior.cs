using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items.Harpy;

namespace Tremor.NPCs
{
	public class HarpyWarrior:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Harpy Warrior");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 300;
			npc.damage = 90;
			npc.defense = 17;
			npc.knockBackResist = 0.3f;
			npc.width = 80;
			npc.height = 60;
			AnimationType = 48;
			npc.aiStyle = 14;
			AIType = 48;
			npc.npcSlots = 1f;
			npc.HitSound = SoundID.NPCHit1;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = Item.buyPrice(0, 0, 8, 9);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<HarpyWarriorBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/HarpyGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/HarpyGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/HarpyGore2"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && Main.hardMode && spawnInfo.Sky ? 0.02f : 0;
	}
}