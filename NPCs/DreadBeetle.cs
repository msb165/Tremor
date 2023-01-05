using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Tremor.Items;
using Tremor.Items.Doom;

namespace Tremor.NPCs
{
	public class DreadBeetle:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dread Beetle");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1800;
			npc.damage = 150;
			npc.defense = 30;
			npc.knockBackResist = 0.6f;
			npc.width = 38;
			npc.height = 44;
			animationType = 258;
			npc.aiStyle = 3;
			aiType = 258;
			npc.npcSlots = 0.2f;
			npc.HitSound = SoundID.NPCHit45;
			npc.DeathSound = SoundID.NPCDeath47;
			npc.value = Item.buyPrice(0, 0, 8, 24);
			banner = npc.type;
			npc.noGravity = false;
			bannerItem = ModContent.ItemType<DreadBeetleBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(2))
				npc.NewItem(ModContent.ItemType<Doomstone>());
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
				for(int i = 0; i < 2; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot($"Gores/DreadGore{i+1}"), 1f);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Main.hardMode && NPC.downedMoonlord && !spawnInfo.Player.ZoneDungeon && spawnInfo.SpawnTileY > Main.rockLayer ? 0.04f : 0f;
	}
}