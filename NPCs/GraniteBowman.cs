using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Granite;

namespace Tremor.NPCs
{
	public class GraniteBowman:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Granite Bowman");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			npc.width = 24;
			npc.height = 44;
			npc.damage = 26;
			npc.defense = 20;
			npc.lifeMax = 95;
			npc.HitSound = SoundID.NPCHit41;
			npc.DeathSound = SoundID.NPCDeath44;
			npc.value = Item.buyPrice(0, 0, 3, 7);
			npc.knockBackResist = 0.2f;
			npc.aiStyle = 3;
			AIType = 111;
			AnimationType = 110;
			npc.buffImmune[20] = true;
			npc.buffImmune[31] = false;
			npc.buffImmune[24] = true;
			Banner = npc.type;
			BannerItem = ModContent.ItemType<GraniteBowmanBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(2))
				this.NewItem(ItemID.Granite, Main.rand.Next(10));
			if (Main.rand.NextBool(2))
				this.NewItem(ModContent.ItemType<StoneofLife>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 31, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("GBGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("GBGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("GBGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("GBGore3"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.SpawnTileType == TileID.Granite && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}
