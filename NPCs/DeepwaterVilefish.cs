using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{

	public class DeepwaterVilefish:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Deepwater Vilefish");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 50;
			npc.damage = 12;
			npc.defense = 3;
			npc.knockBackResist = 0.3f;
			npc.width = 62;
			npc.height = 46;
			AnimationType = 241;
			npc.aiStyle = 16;
			npc.npcSlots = 1f;
			npc.HitSound = SoundID.NPCHit47;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 0, 3);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<DeepwaterVilefishBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
				npc.NewItem(ItemID.RottenChunk);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> spawnInfo.Player.ZoneCorrupt && spawnInfo.SpawnTileY > Main.rockLayer ? 0.05f : 0f;
	}
}