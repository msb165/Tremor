using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class Gelateen:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gelateen");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 500;
			npc.damage = 20;
			npc.defense = 24;
			npc.knockBackResist = 0.6f;
			npc.width = 90;
			npc.height = 62;
			AnimationType = 141;
			npc.aiStyle = 1;
			npc.npcSlots = 1f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 12, 24);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<GelateenBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
				npc.NewItem(ModContent.ItemType<BounceTome>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);
				}
				for(int i = 0; i < 3; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"GelateenGore{i+1}"), 1f);

				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 1, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.SpawnTileY > Main.rockLayer ? 0.001f : 0f;
	}
}