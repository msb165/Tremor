using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class Blazer:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blazer");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 350;
			npc.damage = 100;
			npc.defense = 12;
			npc.knockBackResist = 0.5f;
			npc.width = 40;
			npc.height = 40;
			AnimationType = 121;
			npc.aiStyle = 14;
			npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 10, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<BlazerBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 6, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				if(Main.netMode != 1)
					NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y - 48, NPCID.LavaSlime);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{ 
			return Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && Main.hardMode && spawnInfo.SpawnTileY > Main.maxTilesY - 200 ? 0.02f : 0;
		}
	}
}