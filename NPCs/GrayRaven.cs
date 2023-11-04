using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class GrayRaven:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gray Raven");
			Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults()
		{
			npc.width = 36;
			npc.height = 26;
			npc.aiStyle = 17;
			npc.damage = 22;
			npc.defense = 5;
			npc.lifeMax = 58;
			npc.HitSound = SoundID.NPCHit1;
			npc.knockBackResist = 0.85f;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 50f;
			AnimationType = 301;
			//BannerItem = ModContent.ItemType<GrayRavenBanner>();
		}

		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			player.AddBuff(BuffID.Bleeding, 60, true);
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
				this.NewItem(ModContent.ItemType<RavenFeather>(), Main.rand.Next(1, 3));
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/GrayRavenGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/GrayRavenGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/GrayRavenGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/GrayRavenGore3"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && Main.hardMode && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}