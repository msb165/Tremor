using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class ThinMan:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thin Man");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 10000;
			npc.damage = 160;
			npc.defense = 50;
			npc.knockBackResist = 0.3f;
			npc.width = 18;
			npc.height = 90;
			npc.aiStyle = 3;
			AIType = 77;
			AnimationType = 351;
			npc.npcSlots = 0.2f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 1, 10, 9);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<ThinManBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(5))
				this.NewItem(ModContent.ItemType<BrokenHeroArmorplate>());
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 74, 2.5f * hitDirection, -2.5f, 0, default(Color), 1f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/TMGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/TMGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/TMGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/TMGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/TMGore3"), 1f);

			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> spawnInfo.SpawnTileY < Main.rockLayer && NPC.downedMoonlord && Main.eclipse ? 0.001f : 0f;
	}
}