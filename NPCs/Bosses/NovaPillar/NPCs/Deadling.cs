using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Projectiles;

namespace Tremor.NPCs.Bosses.NovaPillar.NPCs
{
	public class Deadling:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nova Kamikaze");
			Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.aiStyle = 87;
			npc.damage = 60;
			npc.width = 24;
			npc.height = 26;
			npc.defense = 50;
			npc.lifeMax = 1000;
			npc.knockBackResist = 0f;
			AnimationType = 81;
			npc.noGravity = false;
			npc.noTileCollide = false;
			npc.HitSound = SoundID.NPCHit55;
			npc.DeathSound = SoundID.NPCDeath51;
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = npc.lifeMax * 1;
			npc.damage = npc.damage * 1;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.Player.GetModPlayer<TremorPlayer>().ZoneTowerNova)
				return 1f;
			return 0;
		}

		public override bool PreAI()
		{
			if (Main.player[npc.target].GetModPlayer<TremorPlayer>().ZoneRuins)
			{
				npc.life = -1;
				npc.active = false;
				npc.checkDead();
				return false;
			}
			return true;
		}

		public override void PostDraw(SpriteBatch spriteBatch, Vector2 screenPos, Color drawColor)
		{
			TremorUtils.DrawNPCGlowMask(spriteBatch, npc, Mod.GetTexture("NPCs/Bosses/NovaPillar/NPCs/Deadling_GlowMask"));
		}

		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			npc.life = -1;
			npc.active = false;
			npc.checkDead();
			if (NovaHandler.ShieldStrength > 0)
			{
				NPC parent = Main.npc[NPC.FindFirstNPC(ModContent.NPCType<NovaPillar>())];
				Vector2 Velocity = Helper.VelocityToPoint(npc.Center, parent.Center, 20);
				Projectile.NewProjectile(null, npc.Center.X, npc.Center.Y, Velocity.X, Velocity.Y, ModContent.ProjectileType<CogLordLaser>(), 1, 1f);
			}
			for (int i = 0; i < 5; i++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, 57, Main.rand.NextFloat(-3f, 3f), Main.rand.NextFloat(-3f, 3f));
			}
			for (int k = 0; k < 30; k++)
			{
				Vector2 Vector = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
				Vector.Normalize();
				Vector *= Main.rand.Next(10, 201) * 0.01f;
				int i = Projectile.NewProjectile(null, npc.position.X, npc.position.Y, Vector.X, Vector.Y, ModContent.ProjectileType<Projectiles.NovaAlchemistCloud>(), 20, 1f, Main.myPlayer, 0f, Main.rand.Next(-45, 1));
				Main.projectile[i].friendly = false;
			}
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				if (NovaHandler.ShieldStrength > 0)
				{
					NPC parent = Main.npc[NPC.FindFirstNPC(ModContent.NPCType<NovaPillar>())];
					Vector2 Velocity = Helper.VelocityToPoint(npc.Center, parent.Center, 20);
					Projectile.NewProjectile(null, npc.Center.X, npc.Center.Y, Velocity.X, Velocity.Y, ModContent.ProjectileType<CogLordLaser>(), 1, 1f);
				}
				for (int i = 0; i < 5; i++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 57, Main.rand.NextFloat(-3f, 3f), Main.rand.NextFloat(-3f, 3f));
				}
				for (int k = 0; k < 30; k++)
				{
					Vector2 Vector = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
					Vector.Normalize();
					Vector *= Main.rand.Next(10, 201) * 0.01f;
					int i = Projectile.NewProjectile(null, npc.position.X, npc.position.Y, Vector.X, Vector.Y, ModContent.ProjectileType<Projectiles.NovaAlchemistCloud>(), 20, 1f, Main.myPlayer, 0f, Main.rand.Next(-45, 1));
					Main.projectile[i].friendly = false;
				}
			}
		}
	}
}