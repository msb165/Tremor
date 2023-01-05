using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class Zarprute:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zarprute");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1500;
			npc.damage = 70;
			npc.defense = 8;
			npc.knockBackResist = 0.3f;
			npc.width = 92;
			npc.height = 54;
			animationType = 75;
			npc.aiStyle = 14;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit35;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath57;
			npc.value = Item.buyPrice(0, 0, 20, 80);
			banner = npc.type;
			bannerItem = ModContent.ItemType<ZarpruteBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/ZarpruteGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/ZarpruteGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/ZarpruteGore2"), 1f);

				if (Main.netMode == 1) return;

				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y + 15, ModContent.NPCType<Zarprite>());
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<Zarprite>());
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y - 15, ModContent.NPCType<Zarprite>());
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> (Helper.NoZoneAllowWater(spawnInfo)) && Main.hardMode && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}