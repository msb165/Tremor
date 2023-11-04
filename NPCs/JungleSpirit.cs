using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Tremor.NPCs
{
	public class JungleSpirit:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jungle Spirit");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 140;
			npc.damage = 15;
			npc.defense = 14;
			npc.knockBackResist = 0.3f;
			npc.width = 34;
			npc.height = 48;
			AnimationType = 316;
			npc.aiStyle = 22;
			npc.npcSlots = 0.4f;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit44;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath58;
			npc.value = Item.buyPrice(0, 0, 4, 15);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<JungleSpiritBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/JungleSpiritGore"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> (Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo)) && spawnInfo.Player.ZoneJungle && spawnInfo.SpawnTileY > Main.rockLayer ? 0.005f : 0f;
	}
}

