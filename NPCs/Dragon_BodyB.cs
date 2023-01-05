﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs
{
	public class Dragon_BodyB:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Dragon");
			Main.npcFrameCount[npc.type] = 2;
			NPCID.Sets.ShouldBeCountedAsBoss[npc.type] = true;//TechnicallyABoss
		}

		public override void SetDefaults()
		{
			npc.npcSlots = 5f;
			npc.width = 78;
			npc.height = 98;
			npc.defense = 12;
			npc.lifeMax = 3100;
			npc.damage = 28;
			npc.aiStyle = 6;
			aiType = -1;
			animationType = 10;
			npc.knockBackResist = 1f;

			npc.value = Item.buyPrice(0, 25, 0, 0);
			npc.alpha = 255;

			npc.behindTiles = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.netAlways = true;
			music = MusicID.Boss1;
		}

		public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
		{
			return false;
		}

		int time;
		public override void AI()
		{
			if (!Main.npc[(int)npc.ai[1]].active)
			{
				npc.life = 0;
				npc.HitEffect(0, 10.0);
				npc.active = false;
			}
			if (Main.npc[(int)npc.ai[1]].alpha < 128)
			{
				npc.alpha -= 42;
				if (npc.alpha < 0)
				{
					npc.alpha = 0;
				}
			}
			if (npc.life < npc.lifeMax / 2 && Main.netMode != 1 && time == 0 && Main.rand.Next(9000) == 0)
			{
				time = 1;
				int i = NPC.NewNPC(null, (int)(npc.position.X + npc.width / 2), (int)(npc.position.Y + npc.height), ModContent.NPCType<DragonMini>(), 0, 0f, 0f, 0f, 0f, 255);
				npc.frame = GetFrame(2);
				if (Main.netMode == 2 && i < 200)
				{
					//NetMessage.SendData(23, -1, -1, "", i, 0f, 0f, 0f, 0, 0, 0);
				}
				npc.netUpdate = true;
			}
		}

		Rectangle GetFrame(int Number)
		{
			return new Rectangle(0, npc.frame.Height * (Number - 1), npc.frame.Width, npc.frame.Height);
		}

		public override bool CheckActive()
		{
			return false;
		}

		public override bool PreNPCLoot()
		{
			return false;
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = (int)(npc.lifeMax * 0.55f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.75f);
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