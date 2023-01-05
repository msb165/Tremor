using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Ancient;

namespace Tremor.NPCs
{
	//todo: refactor, comparable to HoW
	[AutoloadBossHead]
	public class Dragon_HeadB:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Dragon");
		}

		private bool _tailSpawned;
		public static int ShootRate = 20;

		public override void SetDefaults()
		{
			npc.damage = 28;
			npc.npcSlots = 5f;
			npc.width = 78;
			npc.height = 132;
			npc.defense = 12;
			npc.lifeMax = 3100;
			npc.aiStyle = 6;
			npc.npcSlots = 1f;
			npc.knockBackResist = 0f;

			npc.noTileCollide = true;
			npc.behindTiles = true;
			npc.friendly = false;
			npc.dontTakeDamage = false;
			npc.noGravity = true;
			npc.boss = true;
			npc.lavaImmune = true;

			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Burning] = true;
			
			music = MusicID.Boss2;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			bossBag = ModContent.ItemType<AncientDragonBag>();
		}

		public override void NPCLoot()
		{
			if (Main.expertMode)
			{
				DropBossBags();
			}
			else
			{
				if (Main.rand.NextBool(7))
				{
					Item.NewItem(null, npc.position, npc.Size, ModContent.ItemType<AncientDragonMask>());
				}

				if (Main.rand.NextBool())
				{
					Item.NewItem(null, npc.position, npc.Size, ModContent.ItemType<AncientTimesEdge>());
					Item.NewItem(null, npc.position, npc.Size, ModContent.ItemType<DragonHead>());
					Item.NewItem(null, npc.position, npc.Size, ModContent.ItemType<Swordstorm>());
				}
			}

			if (Main.rand.NextBool(10))
			{
				Item.NewItem(null, npc.position, npc.Size, ModContent.ItemType<AncientDragonTrophy>());
			}

			TremorWorld.Boss.AncientDragon.Downed();
		}

		public override void AI()
		{
			npc.position += npc.velocity * (2 - 1);

			if (!_tailSpawned)
			{
				int Previous = npc.whoAmI;
				for (int num36 = 0; num36 < 19; num36++)
				{
					int lol = 0;
					if (num36 >= 0 && num36 < 18)
					{
						lol = NPC.NewNPC(null, (int)npc.position.X + (npc.width / 2), (int)npc.position.Y + (npc.width / 2), ModContent.NPCType<Dragon_BodyB>(), npc.whoAmI);
					}
					else
					{
						lol = NPC.NewNPC(null, (int)npc.position.X + (npc.width / 2), (int)npc.position.Y + (npc.width / 2), ModContent.NPCType<Dragon_LegB>(), npc.whoAmI);
					}
					Main.npc[lol].realLife = npc.whoAmI;
					Main.npc[lol].ai[2] = npc.whoAmI;
					Main.npc[lol].ai[1] = Previous;
					Main.npc[Previous].ai[0] = lol;
					//NetMessage.SendData(23, -1, -1, "", lol, 0f, 0f, 0f, 0);
					Previous = lol;
				}
				_tailSpawned = true;
			}

			if ((int)(Main.time % 180) == 0)
			{
				Vector2 vector = new Vector2(npc.position.X + (npc.width * 0.5f), npc.position.Y + (npc.height / 2));
				float birdRotation = (float)Math.Atan2(vector.Y - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), vector.X - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
				npc.velocity.X = (float)(Math.Cos(birdRotation) * 7) * -1;
				npc.velocity.Y = (float)(Math.Sin(birdRotation) * 7) * -1;
				npc.netUpdate = true;
			}
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			Texture2D drawTexture = Terraria.GameContent.TextureAssets.Npc[npc.type].Value;
			Vector2 origin = new Vector2((drawTexture.Width / 2) * 0.5F, (drawTexture.Height / Main.npcFrameCount[npc.type]) * 0.5F);

			Vector2 drawPos = new Vector2(
				npc.position.X - Main.screenPosition.X + (npc.width / 2) - (Terraria.GameContent.TextureAssets.Npc[npc.type].Value.Width / 2) * npc.scale / 2f + origin.X * npc.scale,
				npc.position.Y - Main.screenPosition.Y + npc.height - Terraria.GameContent.TextureAssets.Npc[npc.type].Value.Height * npc.scale / Main.npcFrameCount[npc.type] + 4f + origin.Y * npc.scale + npc.gfxOffY);

			SpriteEffects effects = npc.spriteDirection == -1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally;
			spriteBatch.Draw(drawTexture, drawPos, npc.frame, Color.White, npc.rotation, origin, npc.scale, effects, 0);

			return false;
		}
	}
}