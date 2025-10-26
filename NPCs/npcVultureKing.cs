using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Sandstone;

namespace Tremor.NPCs
{
	[AutoloadBossHead]
	public class npcVultureKing:TremorModNPC
	{
		#region "Константы"
		const int AnimationRate = 8; // Частота смены кадров (То, сколько кадров не будет сменятся кадр)
		const int FrameCount = 4; // Кол-во кадров

		const int ShootRate = 50; // Частота выстрела. Будет производить 60/ShootRate выстрелов в секунду
		const int ShootDamage = 15; // Урон от выстрела
		int ShootType; // Тип выстрела (задаётся в SetDefaults())
		const float ShootKnockback = 1; // Отбрасование от выстрела
		const float ShootSpeed = 10; // Скорость выстрела

		const int ShootRate2 = 400; // Частота выстрела. Будет производить 60/ShootRate выстрелов в секунду
		const int ShootDamage2 = 15; // Урон от выстрела
		int ShootType2; // Тип выстрела (задаётся в SetDefaults())
		const float ShootKnockback2 = 1; // Отбрасование от выстрела
		const float ShootSpeed2 = 0; // Скорость выстрела		

		const float DistortPercent = 0.15f; // Процент деформации статов (неточности) (1.0 == 100%)

		const int MinionsID = 61; // ID вуртулек
		const int MinionsCount = 4; // Кол-во вуртулек которых заспавнит

		const int StateTime_Flying = 600; // Сколько будет летать в воздухе до призыва миньонов
		const int StateTime_Minions = 120; // Сколько времени будет спавнить вуртулек

		const int FlyingAI = 2;
		const int MinionsAI = 0;

		const float MinionsState_XDeaccelerationPower = 0.05f; // Скорость замедления по X
		const float MinionsState_YMaxSpeed = 2.80f; // Макс. скорость взлёта во время спавна миньонов
		const float MinionsStete_YSpeedStep = 0.02f; // Скорость увеличения скорости по Y во время спавна миньонов

		const int States = 2;
		#endregion

		#region "Переменные"
		int TimeToAnimation = AnimationRate;
		int Frame;
		bool Shoots = true;
		int TimeToShoot = ShootRate;
		int State;
		int TimeToState = StateTime_Flying;
		bool runAway;
		#endregion

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rukh");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 2500;
			npc.damage = 22;
			npc.defense = 8;
			npc.knockBackResist = 0f;
			npc.width = 160;
			npc.height = 210;
			npc.aiStyle = 2;
			npc.noGravity = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 75, 0);
			npc.boss = true;
			ShootType = ModContent.ProjectileType<Projectiles.projVultureFeather>();
			ShootType2 = 657;
			bossBag = ModContent.ItemType<VultureKingBag>();
			npc.noTileCollide = true;
		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax = (int)(npc.lifeMax * 0.625f * balance);
			npc.damage = (int)(npc.damage * 0.6f);
		}

		public override void AI()
		{
			PlayAnimation(); // Проигрывание анимации
			if (CheckRunConditions())
				return;
			ChangeState(); // Смена стадии
			Shoot(); // Выстрел
			Shoot2(); // Выстрел			
			DoAI(); // Сам искуственный интеллект
		}

		void PlayAnimation()
		{
			if (--TimeToAnimation <= 0)
			{
				TimeToAnimation = (int)Helper.DistortFloat(AnimationRate, DistortPercent);
				if (++Frame >= FrameCount)
					Frame = 0;
			}
		}

		bool CheckRunConditions()
		{
			if (runAway)
			{
				npc.aiStyle = 0;
				if (npc.velocity.Y >= 0)
					npc.velocity.Y = -1f;
				npc.velocity.Y *= 1.01f;
				return true;
			}
			int Target = Helper.GetNearestPlayer(npc.Center, true);
			if (Target == -1)
			{ runAway = true; return true; }
			return false;
		}

		void ChangeState()
		{
			if (--TimeToState < 0)
			{
				State++;
				if (State >= States)
					State = 0;
				switch (State)
				{
					case 0:
						Shoots = true;
						npc.aiStyle = FlyingAI;
						TimeToState = StateTime_Flying;
						break;
					case 1:
						Shoots = false;
						npc.aiStyle = MinionsAI;
						TimeToState = StateTime_Minions;
						break;
				}
			}
		}

		void Shoot()
		{
			if (!Shoots && npc.target < 0)
				return;
			if (--TimeToShoot > 0)
				return;
			TimeToShoot = (int)Helper.DistortFloat(ShootRate, DistortPercent);
			for (int i = 0; i < ((Main.expertMode) ? 3 : 1); i++)
			{
				Vector2 Velocity = Helper.VelocityToPoint(npc.Center, Helper.RandomPointInArea(new Vector2(Main.player[npc.target].Center.X - 10, Main.player[npc.target].Center.Y - 10), new Vector2(Main.player[npc.target].Center.X + 20, Main.player[npc.target].Center.Y + 20)), ShootSpeed);
				int Proj = Projectile.NewProjectile(null, npc.Center.X, npc.Center.Y, Velocity.X, Velocity.Y, ShootType, (int)Helper.DistortFloat(ShootDamage, DistortPercent), Helper.DistortFloat(ShootKnockback, DistortPercent));
				Main.projectile[Proj].Center = npc.Center;
			}
		}

		void Shoot2()
		{
			if (!Shoots && npc.target < 0)
				return;
			if (--TimeToShoot > 0)
				return;
			TimeToShoot = (int)Helper.DistortFloat(ShootRate, DistortPercent);
			for (int i = 0; i < ((Main.expertMode) ? 3 : 1); i++)
			{
				Vector2 Velocity = Helper.VelocityToPoint(npc.Center, Helper.RandomPointInArea(new Vector2(Main.player[npc.target].Center.X - 10, Main.player[npc.target].Center.Y - 10), new Vector2(Main.player[npc.target].Center.X + 20, Main.player[npc.target].Center.Y + 20)), ShootSpeed2);
				int Proj = Projectile.NewProjectile(null, npc.Center.X, npc.Center.Y, Velocity.X, Velocity.Y, ShootType2, (int)Helper.DistortFloat(ShootDamage, DistortPercent), Helper.DistortFloat(ShootKnockback, DistortPercent));
				Main.projectile[Proj].Center = npc.Center;
			}
		}

		void DoAI()
		{
			switch (State)
			{
				case 1:
					npc.velocity.Y -= MinionsStete_YSpeedStep;
					if (npc.velocity.Y < -MinionsState_YMaxSpeed)
						npc.velocity.Y = MinionsState_YMaxSpeed;
					if (TimeToState % StateTime_Minions / MinionsCount == 0)
					{
						Vector2 Position = Helper.RandomPointInArea(npc.Hitbox);
						int index = NPC.NewNPC(null, (int)Position.X, (int)Position.Y, MinionsID);
						Main.npc[index].Center = Position;
					}
					break;
			}
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
		{
			SpriteEffects Direction = (npc.target == -1) ? SpriteEffects.None : ((Main.player[npc.target].position.X < npc.position.X) ? SpriteEffects.None : SpriteEffects.FlipHorizontally);
			spriteBatch.Draw(Terraria.GameContent.TextureAssets.Npc[npc.type].Value, new Rectangle((int)(npc.position.X - Main.screenPosition.X), (int)(npc.position.Y - Main.screenPosition.Y), 240, 160), new Rectangle(0, Frame * 160, 240, 160), drawColor, 0, new Vector2(0, 0), Direction, 0);
			return false;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TRGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TRGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TRGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TRGore2"), 1f);
			}
		}

		public override void NPCLoot()
		{
			if (Main.expertMode)
			{
				DropBossBags();
			}
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + npc.width / 2) / 16;
				int centerY = (int)(npc.position.Y + npc.height / 2) / 16;
				int halfLength = npc.width / 2 / 16 + 1;

				if (!Main.expertMode && Main.rand.NextBool(7))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<VultureKingMask>());
				}
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<VultureKingTrophy>());
				}
				if (!Main.expertMode && Main.rand.NextBool(3))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CactusBow>());
				}
				if (!Main.expertMode && Main.rand.NextBool(3))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SandKnife>());
				}
				if (!Main.expertMode && Main.rand.NextBool(4))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<VultureFeather>());
				}
				if (!Main.expertMode && Main.rand.NextBool())
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SandstoneBar>(), Main.rand.Next(10, 18));
				}

				TremorWorld.Boss.Rukh.Downed();

			}
		}
	}
}