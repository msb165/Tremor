using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Ancient;

namespace Tremor.NPCs
{
	public class FallenWarrior1:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fallen Warrior");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1000;
			npc.damage = 140;
			npc.defense = 82;
			npc.knockBackResist = 0.05f;
			npc.width = 32;
			npc.height = 50;
			AnimationType = 21;
			npc.aiStyle = 3;
			AIType = 273;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 8, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<FallenWarriorBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
				npc.NewItem(ModContent.ItemType<AncientArmorPlate>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("UndeadGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("UndeadGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FWGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FWGore3"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.Player.ZoneDungeon && NPC.downedMoonlord && Main.hardMode && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}