using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Flesh;

namespace Tremor.NPCs
{
	public class HeadlessZombie:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Headless Zombie");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 30;
			npc.damage = 20;
			npc.defense = 5;
			npc.knockBackResist = 0.3f;
			npc.width = 35;
			npc.height = 28;
			AnimationType = 3;
			npc.aiStyle = 26;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 2, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<HeadlessZombieBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(3))
				this.NewItem(ModContent.ItemType<UntreatedFlesh>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombieGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombieGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombieGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombieGore2"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.01f : 0f;
	}
}