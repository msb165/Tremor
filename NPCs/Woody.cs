using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wood;

namespace Tremor.NPCs
{
	public class Woody:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Woody");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 40;
			npc.damage = 18;
			npc.defense = 13;
			npc.knockBackResist = 0.3f;
			npc.width = 56;
			npc.height = 30;
			AnimationType = 141;
			npc.aiStyle = 1;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 2, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<WoodyBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/WoodyGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/WoodyGore2"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.Player.ZoneJungle && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}