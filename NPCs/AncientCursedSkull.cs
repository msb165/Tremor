using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items.Ancient;

namespace Tremor.NPCs
{
	public class AncientCursedSkull:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Cursed  Skull");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 4000;
			npc.damage = 122;
			npc.defense = 80;
			npc.knockBackResist = 0.2f;
			npc.width = 80;
			npc.height = 65;
			AnimationType = 289;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.aiStyle = 10;
			AIType = 289;
			npc.npcSlots = 5f;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 8, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<AncientCursedSkullBanner>();
		}
		
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 60; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 15, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 15, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 15, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				}

				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 15, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Dust.NewDust(npc.position, npc.width, npc.height, 15, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 15, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 15, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
			}
			else
				for (int k = 0; k < damage / npc.lifeMax * 50; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 15, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.Player.ZoneDungeon && NPC.downedMoonlord && Main.hardMode && spawnInfo.SpawnTileY > Main.rockLayer ? 0.008f : 0f;
		}
	}
}