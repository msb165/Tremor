using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles;

namespace Tremor.NPCs.Bosses.NovaPillar.NPCs
{
	public class NovaBat:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nova Bat");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 2250;
			npc.damage = 100;
			npc.defense = 45;
			npc.knockBackResist = 0.3f;
			npc.width = 40;
			npc.height = 20;
			AnimationType = 75;
			npc.aiStyle = 14;
			npc.npcSlots = 0.5f;
			npc.noGravity = true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.Player.GetModPlayer<TremorPlayer>().ZoneTowerNova)
				return 1f;
			return 0;
		}

		public override void PostDraw(SpriteBatch spriteBatch, Vector2 screenPos, Color drawColor)
		{
			TremorUtils.DrawNPCGlowMask(spriteBatch, npc, Mod.GetTexture("NPCs/Bosses/NovaPillar/NPCs/NovaBat_GlowMask"));
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
				for (int k = 0; k < 19; k++)
				{
					Vector2 Vector = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
					Vector.Normalize();
					Vector *= Main.rand.Next(10, 201) * 0.01f;
					int i = Projectile.NewProjectile(null, npc.position.X, npc.position.Y, Vector.X, Vector.Y, ModContent.ProjectileType<Projectiles.NovaAlchemistCloud>(), 20, 1);
					Main.projectile[i].friendly = false;
				}
				for (int i = 0; i < 5; i++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 57, Main.rand.NextFloat(-3f, 3f), Main.rand.NextFloat(-3f, 3f));
				}
				for (int i = 0; i < 2; i++)
				{
					Gore.NewGore(null, npc.Center, npc.velocity, Mod.GetGoreSlot("Gores/NovaBatGore2"));
					Gore.NewGore(null, npc.Center, npc.velocity, Mod.GetGoreSlot("Gores/NovaBatGore2"));
				}
				Gore.NewGore(null, npc.Top, npc.velocity * hitDirection, Mod.GetGoreSlot("Gores/NovaBatGore3"));
				Gore.NewGore(null, npc.Top, npc.velocity * hitDirection, Mod.GetGoreSlot("Gores/NovaBatGore1"));
			}
		}

		public override void AI()
		{
			npc.position += npc.velocity * 1.33f;
			if (Main.time % 120 == 0)
			{
				for (int k = 0; k < 19; k++)
				{
					Vector2 Vector = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
					Vector.Normalize();
					Vector *= Main.rand.Next(10, 201) * 0.01f;
					int i = Projectile.NewProjectile(null, npc.position.X, npc.position.Y, Vector.X, Vector.Y, ModContent.ProjectileType<Projectiles.NovaAlchemistCloud>(), 20, 1);
					Main.projectile[i].friendly = false;
				}
			}
		}
	}
}