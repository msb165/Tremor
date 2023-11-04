using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Souls;

namespace Tremor.NPCs
{
	public class FrostBeetle:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frost Beetle");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 3000;
			npc.damage = 150;
			npc.defense = 72;
			npc.knockBackResist = 0.1f;
			npc.width = 40;
			npc.height = 40;
			AnimationType = 508;
			npc.aiStyle = 3;
			AIType = 508;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit41;
			npc.buffImmune[20] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[39] = true;
			npc.buffImmune[31] = false;
			npc.DeathSound = SoundID.NPCDeath44;
			npc.value = Item.buyPrice(0, 0, 12, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<FrostBeetleBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(2))
				npc.NewItem(ItemID.SnowBlock, 3);
			if (Main.rand.NextBool(2))
				npc.NewItem(ItemID.IceBlock, 3);
			if (Main.rand.NextBool(2))
				npc.NewItem(ModContent.ItemType<FrostCore>(), 3);
			if (NPC.downedMoonlord && Main.rand.NextBool(5))
				npc.NewItem(ModContent.ItemType<IceSoul>());
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hitDirection, -2.5f, 0, default(Color), 1.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hitDirection, -2.5f, 0, default(Color), 2.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IBGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IBGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IBGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IBGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IBGore2"), 1f);
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hitDirection, -2.5f, 0, default(Color), 1.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.6f);
				}
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Main.hardMode && NPC.downedMoonlord && spawnInfo.Player.ZoneSnow && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}