using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class Luminion:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Luminion");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 2000;
			npc.damage = 120;
			npc.defense = 100;
			npc.knockBackResist = 0.0f;
			npc.width = 46;
			npc.height = 32;
			AIType = 417;
			AnimationType = 417;
			npc.aiStyle = 39;
			npc.npcSlots = 2f;
			npc.HitSound = SoundID.NPCHit7;
			npc.DeathSound = SoundID.NPCDeath5;
			npc.value = Item.buyPrice(0, 0, 6, 9);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<LuminionBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(4))
				this.NewItem(ModContent.ItemType<Squorb>(), Main.rand.Next(1, 3));
			if (Main.rand.NextBool())
				this.NewItem(ItemID.LunarBar, Main.rand.Next(3, 8));
			if (Main.rand.NextBool(2))
				this.NewItem(ModContent.ItemType<LunarRoot>(), Main.rand.Next(2, 4));
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 74, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("LuminionGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("LuminionGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("LuminionGore2"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Main.hardMode && NPC.downedMoonlord && !spawnInfo.Player.ZoneDungeon && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}