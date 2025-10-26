using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Flesh;

namespace Tremor.NPCs
{
	public class HeavyZombie:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Heavy Zombie");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 300;
			npc.damage = 80;
			npc.defense = 30;
			npc.knockBackResist = 0.03f;
			npc.width = 34;
			npc.height = 40;
			AnimationType = 3;
			npc.aiStyle = 3;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 11, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<HeavyZombieBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(3))
				npc.NewItem(ModContent.ItemType<UntreatedFlesh>());
			if (Main.rand.NextBool(4))
				npc.NewItem(ItemID.SilverBar, Main.rand.Next(2, 4));
			if (Main.rand.NextBool(4))
				npc.NewItem(ItemID.IronBar, Main.rand.Next(2, 4));
			if (Main.rand.NextBool(4))
				npc.NewItem(ItemID.LeadBar, Main.rand.Next(2, 4));
			if (Main.rand.NextBool(4))
				npc.NewItem(ItemID.TungstenBar, Main.rand.Next(2, 4));
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("HeavyGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("HeavyGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("HeavyGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("HeavyGore3"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> (Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo)) && Main.hardMode && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.03f : 0f;
	}
}