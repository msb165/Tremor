using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.ZombieEvent.Items;

namespace Tremor.NPCs
{
	public class BloodmoonWarrior2:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloodmoon Warrior");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 150;
			npc.damage = 20;
			npc.defense = 10;
			npc.knockBackResist = 0.4f;
			npc.width = 36;
			npc.height = 44;
			AnimationType = 21;
			npc.aiStyle = 3;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit2;
			AIType = 77;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 6, 9);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<BloodmoonWarriorBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/UndeadGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/UndeadGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/BloodmoonWarrior2Gore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/UndeadGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/UndeadGore2"), 1f);
			}
		}
		
		public override void NPCLoot()
		{
			if (Main.rand.Next(25) == 0)
				npc.NewItem((short)ModContent.ItemType<EvilCup>());
			if (Main.rand.Next(25) == 0)
				npc.NewItem((short)ModContent.ItemType<TornPapyrus>());
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return (Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo)) && Main.bloodMoon && spawnInfo.SpawnTileY < Main.worldSurface ? 0.01f : 0f;
		}
	}
}