using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class QuartzBeetle:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Quartz Beetle");
			Main.npcFrameCount[npc.type] = 12;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 3500;
			npc.damage = 140;
			npc.defense = 62;
			npc.knockBackResist = 0.05f;
			npc.width = 32;
			npc.height = 50;
			AnimationType = 185;
			npc.aiStyle = 3;
			AIType = 525;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit41;
			npc.DeathSound = SoundID.NPCDeath44;
			npc.value = Item.buyPrice(0, 0, 8, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<QuartzBeetleBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
				this.NewItem(ModContent.ItemType<PurpleQuartz>(), 2);
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, ModContent.DustType<Dusts.NightmareFlame>(), 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("QBGore1"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.Player.ZoneJungle && NPC.downedMoonlord && Main.hardMode && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}