using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{

	public class ElderObserver:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Elder Observer");
			Main.npcFrameCount[npc.type] = 4;
		}

		const int ShootRate = 220;
		const int ShootDamage = 20;
		const float ShootKN = 1.0f;
		const int ShootType = 100;
		const float ShootSpeed = 4;

		int TimeToShoot = 0;

		public override void SetDefaults()
		{
			npc.lifeMax = 3000;
			npc.damage = 90;
			npc.defense = 32;
			npc.knockBackResist = 0f;
			npc.width = 130;
			npc.height = 130;
			AnimationType = 82;
			npc.aiStyle = 22;
			npc.npcSlots = 0.5f;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit31;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 0, 55, 9);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<ElderObserverBanner>();

			TimeToShoot = 0;
		}

		public override void AI()
		{
			if (Main.netMode != 1 && TimeToShoot++ >= ShootRate && npc.target != -1)
			{
				Shoot();
				TimeToShoot = 0;
			}
		}

		void Shoot()
		{
			Vector2 velocity = Vector2.Normalize(Main.player[npc.target].Center - npc.Center) * ShootSpeed; 
			Projectile.NewProjectile(null, npc.Center.X, npc.Center.Y, velocity.X, velocity.Y, ShootType, ShootDamage, ShootKN);
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				for(int i = 0; i < 4; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"ElderObserverGore{i+1}"), 1f);
			}
			else
			{
				for (int k = 0; k < npc.damage / npc.lifeMax * 50; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 5, hit.HitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, hit.HitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 5, hit.HitDirection, -1f, 0, default(Color), 0.7f);
				}
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(10) == 0)
				npc.NewItem(ModContent.ItemType<Spearaxe>());
			if (Main.rand.Next(10) == 0)
				npc.NewItem(ModContent.ItemType<ScarredReaper>());
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && Main.hardMode && Main.expertMode && Main.bloodMoon && spawnInfo.SpawnTileY < Main.worldSurface ? 0.002f : 0f;
	}
}