using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.NPCs
{
	[AutoloadBossHead]
	public class StormJellyfish:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Storm Jellyfish");
			Main.npcFrameCount[npc.type] = 6;
		}

		const int ShootRate = 100; // ??????? ????????
		const int ShootDamage = 18; // ???? ?? ??????.
		const float ShootKN = 1.0f; // ????????????
		const int ShootType = 435; // ??? ???????????? ??????? ????? ?????????? ???????.
		const float ShootSpeed = 8; // ???, ? ??? ???????, ?????? ?? ????????? ????????
		const int ProjID = 437;
		const int UpSpeed = 6;

		const int ShootRate2 = 660; // ??????? ????????
		const int ShootDamage2 = 15; // ???? ?? ??????.
		const float ShootKN2 = 1.0f; // ????????????
		const int ShootType2 = 465; // ??? ???????????? ??????? ????? ?????????? ???????.
		const float ShootSpeed2 = 5; // ???, ? ??? ???????, ?????? ?? ????????? ????????
		const int ProjID2 = 437;
		const int UpSpeed2 = 6;

		int TimeToShoot = ShootRate; // ????? ?? ????????.

		int TimeToShoot2 = ShootRate2; // ????? ?? ????????.

		public override void SetDefaults()
		{
			npc.width = 140;
			npc.height = 140;
			npc.damage = 18;
			npc.defense = 16;
			npc.lifeMax = 2800;
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.boss = true;
			npc.knockBackResist = 0.1f;
			AIType = 472;
			npc.noGravity = true;
			npc.noGravity = true;
			Music = 39;
			npc.aiStyle = 86;
			AnimationType = 472;
			bossBag = ModContent.ItemType<StormJellyfishBag>();
		}

		public override void AI()
		{
			npc.position += npc.velocity * 0.5f;

			if (--TimeToShoot <= 0 && npc.target != -1) Shoot(); // ? ???? ?????? ?? ?????????? TimeToShot ?????????? 1, ? ???? TimeToShot < ??? = 0, ?? ?????????? ????? Shoot()
			if (--TimeToShoot2 <= 0 && npc.target != -1) Shoot2(); // ? ???? ?????? ?? ?????????? TimeToShot ?????????? 1, ? ???? TimeToShot < ??? = 0, ?? ?????????? ????? Shoot()

			if (Main.rand.Next(400) == 0)
			{
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<FlyingJelly>());
			}
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 60; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 226, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 226, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 226, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("StormGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("StormGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("StormGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("StormGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("StormGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("StormGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("StormGore4"), 1f);
			}
			else
			{

				for (int k = 0; k < npc.damage / npc.lifeMax * 50.0; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 226, hit.HitDirection, -2f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 27, hit.HitDirection, -1f, 0, default(Color), 0.7f);
				}
			}
		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax = npc.lifeMax * 1;
			npc.damage = npc.damage * 1;
		}

		void Shoot()
		{
			TimeToShoot = ShootRate;
			Vector2 velocity = VelocityFPTP(npc.Center, Main.player[npc.target].Center, ShootSpeed);
			Projectile.NewProjectile(null, npc.Center.X, npc.Center.Y, velocity.X, velocity.Y, ShootType, ShootDamage, ShootKN);
		}

		void Shoot2()
		{
			TimeToShoot2 = ShootRate2;
			Vector2 velocity = VelocityFPTP(npc.Center, Main.player[npc.target].Center, ShootSpeed2);
			Projectile.NewProjectile(null, npc.Center.X, npc.Center.Y, velocity.X, velocity.Y, ShootType2, ShootDamage2, ShootKN2);
		}

		Vector2 VelocityFPTP(Vector2 pos1, Vector2 pos2, float speed)
		{
			Vector2 move = pos2 - pos1;
			return move * (speed / (float)Math.Sqrt(move.X * move.X + move.Y * move.Y));
		}

		public override void NPCLoot()
		{
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + npc.width / 2) / 16;
				int centerY = (int)(npc.position.Y + npc.height / 2) / 16;
				int halfLength = npc.width / 2 / 16 + 1;

				if (Main.expertMode)
				{
					DropBossBags();
				}

				if (!Main.expertMode && Main.rand.NextBool(7))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StormJellyfishMask>());
				}
				if (!Main.expertMode && Main.rand.NextBool(4))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StormBlade>());
				}
				if (!Main.expertMode && Main.rand.NextBool(3))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Poseidon>());
				}
				if (!Main.expertMode && Main.rand.NextBool(3))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<JellyfishStaff>());
				}
				if (!Main.expertMode && Main.rand.NextBool(3))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<BoltTome>());
				}
				if (!Main.expertMode && Main.rand.NextBool(3))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StickyFlail>());
				}
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StormJellyfishTrophy>());
				}
				TremorWorld.Boss.StormJellyfish.Downed();
			}
		}

	}
}