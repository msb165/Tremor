using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Flesh;

namespace Tremor.NPCs
{
	public class SquidZombie:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Squid Zombie");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 125;
			npc.damage = 25;
			npc.defense = 6;
			npc.knockBackResist = 0.6f;
			npc.width = 34;
			npc.height = 60;
			AnimationType = 3;
			npc.aiStyle = 3;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 4, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<SquidZombieBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(24) == 0)
				this.NewItem(ModContent.ItemType<SquidHat>());
			if (Main.rand.NextBool(3))
				this.NewItem(ModContent.ItemType<UntreatedFlesh>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombieGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombieGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("SquidGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombieGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZombieGore2"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Main.tileSand[spawnInfo.SpawnTileType] && Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.Water && spawnInfo.SpawnTileY < Main.rockLayer && (spawnInfo.SpawnTileX < 250 || spawnInfo.SpawnTileX > Main.maxTilesX - 250) && !spawnInfo.PlayerSafe ? 0.01f : 0f;
	}
}