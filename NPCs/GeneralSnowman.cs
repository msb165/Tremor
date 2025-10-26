using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class GeneralSnowman:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("General Snowman");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 800;
			npc.damage = 50;
			npc.defense = 22;
			npc.knockBackResist = 0.1f;
			npc.width = 34;
			npc.height = 46;
			AnimationType = 143;
			npc.aiStyle = 38;
			AIType = 143;
			npc.npcSlots = 0.3f;
			npc.HitSound = SoundID.NPCHit11;
			npc.DeathSound = SoundID.NPCDeath15;
			npc.value = Item.buyPrice(0, 0, 8, 7);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<GeneralSnowmanBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1f);

				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 3f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 2f);
				Dust.NewDust(npc.position, npc.width, npc.height, 76, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 3f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> NPC.AnyNPCs(NPCID.MisterStabby) && Main.hardMode && spawnInfo.SpawnTileY < Main.worldSurface ? 0.01f : 0f;
	}
}