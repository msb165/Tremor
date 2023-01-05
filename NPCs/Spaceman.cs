using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Tremor.NPCs
{
	public class Spaceman:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spaceman");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 52;
			npc.damage = 22;
			npc.defense = 12;
			npc.lifeMax = 200;
			npc.HitSound = SoundID.NPCHit48;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 3, 12);
			npc.knockBackResist = 0.3f;
			npc.aiStyle = 3;
			aiType = 73;
			npc.aiStyle = 3;
			animationType = 31;
			// banner = npc.type;
			// Todo: bannerItem = ModContent.ItemType<SpacemanBanner>();
		}

		public override void AI()
		{
			if (Main.rand.Next(1000) == 0)
				Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[61], npc.position);//Variant 1
			if (Main.rand.Next(1000) == 0)
				Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[62], npc.position);//Variant 1
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(6))
				this.NewItem(ItemID.Meteorite, Main.rand.Next(1, 6));
			if (Main.rand.NextBool(6))
				this.NewItem(ItemID.MeteoriteBar, Main.rand.Next(1, 3));
			if (Main.rand.Next(46) == 0)
				this.NewItem(ItemID.SpaceGun, Main.rand.Next(1));
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SpaceManGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SpaceManGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SpaceManGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SpaceManGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SpaceManGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SpaceManGore4"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> spawnInfo.SpawnTileY < Main.rockLayer && spawnInfo.Player.ZoneMeteor && Main.dayTime ? 0.03f : 0f;
	}
}
