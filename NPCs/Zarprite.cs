using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class Zarprite:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zarprite");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 150;
			npc.damage = 10;
			npc.defense = 12;
			npc.knockBackResist = 0.3f;
			npc.width = 34;
			npc.height = 48;
			AnimationType = 75;
			npc.aiStyle = 14;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit35;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath57;
			npc.value = Item.buyPrice(0, 0, 15, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<ZarpriteBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZarpriteGore"), 1f);

				if (Main.netMode == 1) return;

				NPC.NewNPC(null, (int)npc.position.X - 6, (int)npc.position.Y + 6, ModContent.NPCType<Parasprite>());
				NPC.NewNPC(null, (int)npc.position.X + 6, (int)npc.position.Y, ModContent.NPCType<Parasprite>());
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y - 6, ModContent.NPCType<Parasprite>());
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> (Helper.NoZoneAllowWater(spawnInfo)) && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}