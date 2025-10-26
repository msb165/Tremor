using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs
{
	public class InfectedZombie:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Infected Zombie");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 95;
			npc.damage = 25;
			Main.npcFrameCount[npc.type] = 3;
			npc.defense = 14;
			npc.knockBackResist = 0.3f;
			npc.width = 34;
			npc.height = 46;
			AnimationType = 3;
			npc.aiStyle = 3;
			npc.npcSlots = 1f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 15, 9);
			//BannerItem = ModContent.ItemType<InfectedZombieBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && !Main.dayTime && NPC.downedBoss2 && spawnInfo.Player.ZoneCrimson && spawnInfo.SpawnTileY < Main.worldSurface ? 0.02f : 0;
	}
}