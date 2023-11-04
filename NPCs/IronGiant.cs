using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class IronGiant:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Giant");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 60;
			npc.damage = 31;
			npc.defense = 30;
			npc.lifeMax = 800;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 0, 28, 7);
			npc.knockBackResist = 0.3f;
			npc.aiStyle = 3;
			AIType = 343;
			AnimationType = 343;
			npc.buffImmune[20] = true;
			npc.buffImmune[31] = false;
			npc.buffImmune[24] = true;
			Banner = npc.type;
			BannerItem = ModContent.ItemType<IronGiantBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(8))
				this.NewItem(ModContent.ItemType<ElectricSpear>());
			if (Main.rand.Next(10) == 0)
				this.NewItem(ItemID.DepthMeter);
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 31, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IGGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IGGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IGGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IGGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IGGore4"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/IGGore4"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> (Helper.NoZoneAllowWater(spawnInfo)) && Main.hardMode && spawnInfo.SpawnTileY > Main.rockLayer ? 0.001f : 0f;
	}
}
