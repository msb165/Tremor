using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

using Tremor.Items;
using Tremor.Items.Alchemist.Flasks;
using Tremor.Items.Ancient;
using Tremor.Items.Antlion;
using Tremor.Items.Arach;
using Tremor.Items.Chaos;
using Tremor.Items.Crystal;
using Tremor.Items.Dark;
using Tremor.Items.Flesh;
using Tremor.Items.Heaven;
using Tremor.Items.Souls;
using Tremor.Items.Wood;
using Tremor.NPCs.Bosses.Motherboard.Items;

namespace Tremor.NPCs
{
	public class TremorNPC : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			//ItemDropWithConditionRule
			//ItemDropRule.ByCondition(Conditions.)
			base.ModifyNPCLoot(npc, npcLoot);
		}
		//TODO: Convert to loot method
		public override void OnKill(NPC npc)
		{
			if (NPC.downedMoonlord)
			{
				switch(npc.type)
				{
					case NPCID.IceSlime:
					case NPCID.IceBat:
					case NPCID.IceTortoise:
					case NPCID.Wolf:
					case NPCID.ZombieEskimo:
					case NPCID.UndeadViking:
					case NPCID.CorruptPenguin:
					case NPCID.IceElemental:
					case NPCID.SpikedIceSlime:
					case NPCID.SnowFlinx:
					case NPCID.ArmoredViking:
					case NPCID.IcyMerman:
					case NPCID.ArmedZombieEskimo:
						if (Main.rand.NextBool(7))
						{
							Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceSoul>());
						}
						break;
				}
			}

			if (npc.type == NPCID.ArmoredSkeleton && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<TheRib>());
			}

			if (npc.type == NPCID.SkeletonArcher && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<TheRib>());
			}

			if (npc.type == NPCID.GraniteFlyer && Main.rand.NextBool(4))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<StoneofLife>());
			}

			if (npc.type == NPCID.GreekSkeleton && Main.rand.NextBool(4))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<StoneofLife>());
			}

			if (npc.type == NPCID.PossessedArmor && Main.rand.NextBool(25))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PossessedHelmet>());
			}

			if (npc.type == NPCID.PossessedArmor && Main.rand.NextBool(25))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PossessedChestplate>());
			}

			if (npc.type == NPCID.PossessedArmor && Main.rand.NextBool(25))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PossessedGreaves>());
			}

			if (!Main.expertMode && npc.type == NPCID.SkeletronPrime && Main.rand.NextBool(6))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PrimeBlade>());
			}

			if (!Main.expertMode && npc.type == NPCID.TheDestroyer && Main.rand.NextBool(6))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<Destructor>());
			}

			if (((npc.type == NPCID.BrainScrambler) || (npc.type == NPCID.RayGunner) || (npc.type == NPCID.MartianOfficer) || (npc.type == NPCID.GrayGrunt) || (npc.type == NPCID.MartianEngineer) ||
				 (npc.type == NPCID.MartianDrone) || (npc.type == NPCID.GigaZapper) || (npc.type == NPCID.ScutlixRider) || (npc.type == NPCID.Scutlix) || (npc.type == NPCID.MartianWalker)) &&
				Main.rand.NextBool(500))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<Transistor>());
			}

			if (!Main.expertMode && npc.type == NPCID.WallofFlesh && Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PieceofFlesh>(), Main.rand.Next(8, 17));
			}

			if (npc.type == NPCID.BloodZombie && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Stigmata>());
			}

			if (npc.type == NPCID.Demon && Main.rand.NextBool(2))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<DemonBlood>());
			}

			if (npc.type == NPCID.VoodooDemon && Main.rand.NextBool(2))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<DemonBlood>());
			}

			if (npc.type == NPCID.GoblinArcher && Main.rand.NextBool(20))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LongBow>());
			}

			if (npc.type == NPCID.SkeletronPrime && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<BenderHead>());
			}

			if (npc.type == NPCID.Retinazer && Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<BenderBody>());
			}

			if (npc.type == NPCID.Spazmatism && Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<BenderBody>());
			}

			if (npc.type == NPCID.TheDestroyer && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<BenderLegs>());
			}

			if (npc.type == NPCID.Hornet && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ToxicHilt>());
			}

			if (npc.type == NPCID.HornetFatty && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ToxicHilt>());
			}

			if (npc.type == NPCID.HornetHoney && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ToxicHilt>());
			}

			if (npc.type == NPCID.HornetLeafy && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ToxicHilt>());
			}

			if (npc.type == NPCID.HornetSpikey && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ToxicHilt>());
			}

			if (npc.type == NPCID.HornetStingy && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ToxicHilt>());
			}

			if (npc.type == NPCID.EaterofSouls && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PiercingQuartz>());
			}

			if (npc.type == NPCID.BloodCrawler && Main.rand.NextBool(30))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<Vertebrow>());
			}

			if (npc.type == NPCID.SwampThing && Main.rand.NextBool(28))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<SwampClump>());
			}

			if (npc.type == NPCID.ThePossessed && Main.rand.NextBool(28))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<LeechingSeed>());
			}

			if (npc.type == NPCID.SwampThing && Main.rand.NextBool(25))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<FiercePaw>());
			}

			if (npc.type == NPCID.Butcher && Main.rand.NextBool(20))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ButcherMask>());
			}

			if (npc.type == NPCID.AngryTrapper && Main.rand.NextBool(2))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ThornBall>(), Main.rand.Next(6, 15));
			}

			if (npc.type == NPCID.WallCreeper && Main.rand.NextBool(40))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<Arachnophobia>());
			}

			if (npc.type == NPCID.WallCreeperWall && Main.rand.NextBool(40))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<Arachnophobia>());
			}

			if (!TremorWorld.Boss.Motherboard.IsDowned() && Main.hardMode && Main.rand.NextBool(2500))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MechanicalBrain>());
			}

			if (npc.type == NPCID.DesertBeast && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PetrifiedSpike>(), Main.rand.Next(5, 10));
			}

			if (npc.type == NPCID.DesertScorpionWalk && Main.rand.NextBool(16))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ScorpionStinger>());
			}

			if (npc.type == NPCID.DesertScorpionWall && Main.rand.NextBool(16))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ScorpionStinger>());
			}

			if (npc.type == NPCID.MeteorHead && Main.rand.NextBool(100))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<AncientMeteorHelmet>());
			}

			if (npc.type == NPCID.SantaNK1 && Main.rand.NextBool(7))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<SantaNK1Mask>());
			}

			if (npc.type == NPCID.IceQueen && Main.rand.NextBool(7))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<IceQueenMask>());
			}

			if (npc.type == NPCID.Everscream && Main.rand.NextBool(7))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<EverscreamMask>());
			}

			if (npc.type == NPCID.Pumpking && Main.rand.NextBool(7))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PumpkingMask>());
			}

			if (npc.type == NPCID.PumpkingBlade && Main.rand.NextBool(7))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PumpkingMask>());
			}

			if (npc.type == NPCID.MourningWood && Main.rand.NextBool(7))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MourningWoodMask>());
			}

			if (npc.type == NPCID.PirateShip && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PirateChest>());
			}

			if (!Main.expertMode && npc.type == NPCID.Golem && Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<GolemCore>());
			}

			if (npc.type == NPCID.Mechanic && Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ThrowingWrench>(), Main.rand.Next(10, 20));
			}

			if (npc.type == NPCID.TombCrawlerHead && Main.rand.NextBool(25))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<IonBlaster>());
			}

			if (npc.type == NPCID.TombCrawlerHead && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PetrifiedSpike>(), Main.rand.Next(5, 10));
			}

			if ((npc.type == NPCID.Zombie || npc.type == NPCID.BaldZombie || npc.type == NPCID.PincushionZombie || npc.type == NPCID.SlimedZombie || npc.type == NPCID.SwampZombie ||
				 npc.type == NPCID.TwiggyZombie || npc.type == NPCID.FemaleZombie || npc.type == NPCID.BaldZombie || npc.type == NPCID.ZombieDoctor || npc.type == NPCID.ZombieSuperman ||
				 npc.type == NPCID.ZombiePixie || npc.type == NPCID.ZombieXmas || npc.type == NPCID.ZombieSweater || npc.type == NPCID.ArmedZombie || npc.type == NPCID.ArmedZombiePincussion ||
				 npc.type == NPCID.ArmedZombieSlimed || npc.type == NPCID.ArmedZombieSwamp || npc.type == NPCID.ArmedZombieTwiggy || npc.type == NPCID.ArmedZombieCenx) && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<UntreatedFlesh>());
			}

			if ((npc.type == NPCID.Harpy || npc.type == NPCID.Pixie || npc.type == NPCID.WyvernHead) && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<AirFragment>());
			}

			if ((npc.type == NPCID.Piranha || npc.type == NPCID.Shark || npc.type == NPCID.BlueJellyfish || npc.type == NPCID.PinkJellyfish || npc.type == NPCID.AnglerFish ||
				 npc.type == NPCID.GreenJellyfish || npc.type == NPCID.Arapaima) && Main.rand.NextBool(2))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<SeaFragment>());
			}

			if ((npc.type == NPCID.GiantWormHead || npc.type == NPCID.DiggerHead || npc.type == NPCID.Snatcher || npc.type == NPCID.GiantTortoise || npc.type == NPCID.AngryTrapper ||
				 npc.type == NPCID.MossHornet || npc.type == NPCID.Moth || npc.type == NPCID.HornetFatty || npc.type == NPCID.HornetHoney || npc.type == NPCID.HornetLeafy ||
				 npc.type == NPCID.HornetSpikey || npc.type == NPCID.HornetStingy || npc.type == NPCID.JungleCreeper || npc.type == NPCID.JungleCreeperWall) && Main.rand.NextBool(4))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<EarthFragment>());
			}

			if ((npc.type == NPCID.FireImp || npc.type == NPCID.LavaSlime || npc.type == NPCID.Hellbat || npc.type == NPCID.Lavabat || npc.type == NPCID.Demon ||
				 npc.type == NPCID.VoodooDemon) && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<FireFragment>());
			}

			if ((npc.type == NPCID.Psycho || npc.type == NPCID.DeadlySphere || npc.type == NPCID.DrManFly || npc.type == NPCID.Nailhead || npc.type == NPCID.Butcher) &&
				Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<DarkMatter>(), Main.rand.Next(2, 3));
			}

			if (npc.type == NPCID.GiantShelly && Main.rand.NextBool(22))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PurpleShelmet>());
			}

			if (npc.type == NPCID.GiantShelly2 && Main.rand.NextBool(22))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<OrangeShelmet>());
			}

			if (npc.lifeMax > 100 && npc.lifeMax < 200 && Main.rand.NextBool(300))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<TinySai>());
			}
			if (npc.value > 100f && npc.value < 1000f && Main.rand.NextBool(300))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<RoyalClaymore>());
			}
			if (npc.lifeMax > 200 && npc.lifeMax < 500 && Main.rand.NextBool(300))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MassiveHammer>());
			}
			if (npc.defense > 10 && npc.defense < 30 && Main.rand.NextBool(300))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Crowbar>());
			}
			if (npc.damage < 200 && npc.damage > 80 && Main.hardMode && Main.rand.NextBool(300))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Narsil>());
			}
			if (npc.boss && !Main.hardMode && Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<HeavenHelmet>());
			}
			if (npc.boss && !Main.hardMode && Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<HeavenBreastplate>());
			}
			if (npc.boss && !Main.hardMode && Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<HeavenLeggings>());
			}

			if (npc.type == NPCID.EaterofWorldsHead && Main.rand.NextBool(20))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<CorruptorStaff>());
			}

			if (npc.type == NPCID.BrainofCthulhu && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<CreeperStaff>());
			}

			if (Main.xMas && !Main.LocalPlayer.HasItem(ModContent.ItemType<SuspiciousLookingPresent>()) &&
				Main.rand.NextBool(250))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<SuspiciousLookingPresent>());
			}

			if (NPC.downedMoonlord && Main.rand.NextBool(250))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<SuspiciousBag>());
			}

			if (NPC.downedMoonlord && Main.LocalPlayer.ZoneDungeon && Main.rand.NextBool(4))
			{
				if (npc.lifeMax > 200 && !Main.expertMode)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
						ModContent.ItemType<Phantaplasm>());
				}
				if (npc.lifeMax > 400 && Main.expertMode)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
						ModContent.ItemType<Phantaplasm>());
				}
			}

			if (npc.type == NPCID.DevourerHead && Main.rand.NextBool(26))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<CorruptorGun>());
			}
			if ((npc.type == NPCID.Antlion || npc.type == NPCID.GiantWalkingAntlion) && Main.rand.NextBool(6))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<AntlionShell>());
			}
			if (npc.type == NPCID.BirdRed && Main.rand.NextBool(100))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<RedMask>());
			}

			if (npc.type == NPCID.Crawdad && Main.rand.NextBool(29))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<RedClaw>());
			}
			if (npc.type == NPCID.Crawdad2 && Main.rand.NextBool(29))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<GreenClaw>());
			}
			if ((npc.type == NPCID.Salamander || npc.type == NPCID.Salamander2 || npc.type == NPCID.Salamander3 || npc.type == NPCID.Salamander4 || npc.type == NPCID.Salamander5 ||
				 npc.type == NPCID.Salamander6 || npc.type == NPCID.Salamander7 || npc.type == NPCID.Salamander8 || npc.type == NPCID.Salamander9) && Main.rand.NextBool(2))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<SalamanderSkin>(), Main.rand.Next(2));
			}

			if ((npc.type == NPCID.Crimera) && Main.rand.NextBool(40))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<CrimCudgel>());
			}

			if ((npc.type == NPCID.EyeofCthulhu) && Main.rand.NextBool(10))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<TriangleMask>());
			}

			if ((npc.type == NPCID.SkeletronHead) && Main.rand.NextBool(6))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<TheArtifact>());
			}

			if (Main.eclipse && NPC.downedMoonlord && Main.rand.NextBool(10))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ToothofAbraxas>());
			}

			if ((npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism || npc.type == NPCID.SkeletronPrime || npc.type == NPCID.TheDestroyer) && NPC.downedMoonlord &&
				Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<CarbonSteel>(), Main.rand.Next(6, 12));
			}

			//if ((npc.type == 21 || npc.type == 449 || npc.type == 450 || npc.type == 451 || npc.type == 452 ||
			//	 npc.type == 322 || npc.type == 323 || npc.type == 324 || npc.type == 294 || npc.type == 295 ||
			//	 npc.type == 296 || npc.type == 201 || npc.type == 202 || npc.type == 20 || npc.type == 450 ||
			//	 npc.type == 451 || npc.type == 452) && WorldGen.shadowOrbSmashed && Main.rand.NextBool(8))
			//{
			//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
			//		ModContent.ItemType<RedSteelArmorPiece>());
			//}

			//if ((npc.type == 21 || npc.type == 449 || npc.type == 450 || npc.type == 451 || npc.type == 452 ||
			//	 npc.type == 322 || npc.type == 323 || npc.type == 324 || npc.type == 294 || npc.type == 295 ||
			//	 npc.type == 296 || npc.type == 201 || npc.type == 202 || npc.type == 20 || npc.type == 450 ||
			//	 npc.type == 451 || npc.type == 452) && WorldGen.shadowOrbSmashed && Main.rand.NextBool(8))
			//{
			//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
			//		ModContent.ItemType<FaultyRedSteelShield>());
			//}

			//if ((npc.type == 21 || npc.type == 449 || npc.type == 450 || npc.type == 451 || npc.type == 452 ||
			//	 npc.type == 322 || npc.type == 323 || npc.type == 324 || npc.type == 294 || npc.type == 295 ||
			//	 npc.type == 296 || npc.type == 201 || npc.type == 202 || npc.type == 20 || npc.type == 450 ||
			//	 npc.type == 451 || npc.type == 452) && WorldGen.shadowOrbSmashed && Main.rand.NextBool(8))
			//{
			//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
			//		ModContent.ItemType<ChippyRedSteelSword>());
			//}

			if ((npc.type == NPCID.BloodZombie) && Main.rand.NextBool(24))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<TheBrain>());
			}

			if ((npc.type == NPCID.Drippler) && Main.rand.NextBool(4))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<DrippingRoot>());
			}

			if ((npc.aiStyle == 1) && NPC.downedMoonlord && Main.rand.NextBool(60))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkMass>());
			}

			if ((npc.type == NPCID.WallCreeper || npc.type == NPCID.WallCreeperWall) && Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<SpiderMeat>(), Main.rand.Next(1, 3));
			}

			if ((npc.type == NPCID.SeekerHead || npc.type == NPCID.Corruptor || npc.type == NPCID.Clinger || npc.type == NPCID.PigronCorruption || npc.type == NPCID.PigronCrimson ||
				 npc.type == NPCID.FloatyGross) && NPC.downedMoonlord && Main.rand.NextBool(7))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ClusterShard>(), Main.rand.Next(1, 2));
			}

			if ((npc.type == NPCID.AngryTrapper || npc.type == NPCID.Moth || npc.type == NPCID.FlyingSnake) && NPC.downedMoonlord && Main.rand.NextBool(4))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<DragonCapsule>(), Main.rand.Next(1, 2));
			}

			if (npc.type == NPCID.Paladin && NPC.downedMoonlord && Main.rand.NextBool(20))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PaladinHelmet>());
			}

			if (npc.type == NPCID.Paladin && NPC.downedMoonlord && Main.rand.NextBool(20))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PaladinBreastplate>());
			}

			if (npc.type == NPCID.Paladin && NPC.downedMoonlord && Main.rand.NextBool(20))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<PaladinGreaves>());
			}

			if (!Main.expertMode && npc.type == NPCID.SkeletronHead)
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<TearsofDeath>(), Main.rand.Next(1, 3));
			}

			if (npc.type == NPCID.IceElemental && Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<FrostCore>(), Main.rand.Next(1, 3));
			}

			if (npc.type == NPCID.ArmedZombieEskimo && Main.rand.NextBool(8))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<FrostCore>(), Main.rand.Next(1, 2));
			}

			if (npc.type == NPCID.ZombieEskimo && Main.rand.NextBool(8))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<FrostCore>(), Main.rand.Next(1, 2));
			}

			if (npc.type == NPCID.Mothron && Main.rand.NextBool(4))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<BrokenHeroAmulet>());
			}

			if (npc.type == NPCID.DarkCaster && Main.rand.NextBool(50))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<WaterStorm>());
			}

			if (npc.type == NPCID.CursedSkull && Main.rand.NextBool(50))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<WaterStorm>());
			}

			if (npc.type == NPCID.CursedSkull && Main.rand.NextBool(40))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<KeyKnife>());
			}

			if (!Main.expertMode && npc.type == NPCID.EyeofCthulhu && Main.rand.NextBool(5))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<EyeMonolith>());
			}

			if (!Main.expertMode && npc.type == NPCID.EyeofCthulhu && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MonsterTooth>(), Main.rand.Next(20, 40));
			}

			if (npc.type == NPCID.UndeadViking && Main.rand.NextBool(32))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<NorthAxe>());
			}

			if (npc.type == NPCID.UndeadViking && Main.rand.NextBool(32))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<NorthHammer>());
			}

			if (npc.type == NPCID.UndeadViking && Main.rand.NextBool(32))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<NorthCutlass>());
			}

			if (npc.type == NPCID.Wraith && Main.rand.NextBool(40))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<WrathofWraith>());
			}

			if (npc.type == NPCID.CultistBoss && Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<AncientTablet>(), Main.rand.Next(12, 22));
			}

			if (npc.type == NPCID.Plantera && Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<EssenseofJungle>(), Main.rand.Next(2, 3));
			}

			//if (npc.type == NPCID.DukeFishron && !Main.expertMode && Main.rand.NextBool(6))
			//{
			//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
			//		ModContent.ItemType<DukesCannon>(), Main.rand.Next(2, 3));
			//}

			if (npc.type == NPCID.IlluminantSlime && Main.rand.NextBool(35))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<CrystalSpear>(), Main.rand.Next(2, 3));
			}

			if (npc.type == NPCID.IlluminantBat && Main.rand.NextBool(35))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<CrystalSpear>(), Main.rand.Next(2, 3));
			}

			//if (npc.type == NPCID.BoneSerpentHead && Main.rand.Next(40) == 0)
			//{
			//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
			//		ModContent.ItemType<GunBlade>(), Main.rand.Next(2, 3));
			//}

			if (npc.type == NPCID.SantaNK1 && Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<SpiK3Ball>(), Main.rand.Next(50, 100));
			}

			if (!NPC.downedMoonlord && (npc.type == NPCID.Pixie || npc.type == NPCID.Unicorn || npc.type == NPCID.RainbowSlime || npc.type == NPCID.Gastropod || npc.type == NPCID.LightMummy || npc.type == NPCID.DesertGhoulHallow) && Main.rand.NextBool(50))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<UnstableCrystal>());
			}

			if (npc.type == NPCID.Merchant && Main.rand.NextBool(2))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MoneySack>(), Main.rand.Next(2, 4));
			}

			if (npc.type == NPCID.MoonLordCore)
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MultidimensionalFragment>(), Main.rand.Next(6, 12));
			}

			if (!Main.expertMode && npc.type == NPCID.QueenBee && Main.rand.NextBool(3))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<YellowPuzzleFragment>());
			}

			if ((npc.type == NPCID.BrainScrambler || npc.type == NPCID.RayGunner || npc.type == NPCID.MartianOfficer || npc.type == NPCID.GrayGrunt || npc.type == NPCID.MartianEngineer || npc.type == NPCID.MartianTurret || npc.type == NPCID.MartianDrone || npc.type == NPCID.GigaZapper || npc.type == NPCID.ScutlixRider) && Main.rand.NextBool(100))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<WarpPad>());
			}

			if ((npc.type == NPCID.BlueArmoredBones || npc.type == NPCID.BlueArmoredBonesMace || npc.type == NPCID.BlueArmoredBonesNoPants || npc.type == NPCID.BlueArmoredBonesSword || npc.type == NPCID.RustyArmoredBonesAxe || npc.type == NPCID.RustyArmoredBonesFlail || npc.type == NPCID.RustyArmoredBonesSword || npc.type == NPCID.RustyArmoredBonesSwordNoArmor || npc.type == NPCID.HellArmoredBones || npc.type == NPCID.HellArmoredBonesSpikeShield || npc.type == NPCID.HellArmoredBonesMace || npc.type == NPCID.HellArmoredBonesSword || npc.type == NPCID.Necromancer || npc.type == NPCID.NecromancerArmored || npc.type == NPCID.RaggedCaster || npc.type == NPCID.RaggedCasterOpenCoat || npc.type == NPCID.DiabolistRed || npc.type == NPCID.DiabolistWhite) && Main.rand.NextBool(25))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<BottledSpirit>());
			}

			if ((npc.type == NPCID.TheDestroyer || npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism || npc.type == NPCID.SkeletronPrime) && NPC.downedMechBossAny && Main.rand.NextBool(10))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<FlaskCore>());
			}

			if (npc.type == NPCID.AngryTrapper && Main.rand.NextBool(50))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<RichMahoganySeed>());
			}

			if (!Main.expertMode && npc.type == NPCID.Spazmatism && !NPC.AnyNPCs(125) && Main.rand.NextBool(6))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MechaSprayer>());
			}

			if (!Main.expertMode && npc.type == NPCID.Retinazer && !NPC.AnyNPCs(126) && Main.rand.NextBool(6))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MechaSprayer>());
			}

			if (npc.type == NPCID.MartianSaucerCore && Main.rand.NextBool(20))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<MartianSprayer>());
			}

			if (npc.type == NPCID.DukeFishron && Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<DukeFlask>(), Main.rand.Next(550, 750));
			}

			if (npc.type == NPCID.ChaosElemental && Main.rand.NextBool(20))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<ChaosElement>());
			}

			if ((npc.type == NPCID.Frog || npc.type == NPCID.GoldFrog) && Main.rand.NextBool(33))
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<FrogMask>());
			}
			if (npc.type == NPCID.SkeletronHead && Main.rand.NextBool())
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
					ModContent.ItemType<CursedSoul>(), Main.rand.Next(1, 5));
			}

			if (npc.type == NPCID.MoonLordCore)
			{
				if (!TremorWorld.Boss.Tremode.IsDowned())
				{
					Main.NewText("Nightmares became reality!", 90, 0, 157);
					Main.NewText("The moon slowly drifts towards the Earth...", 0, 255, 255);

					for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
					{
						int i2 = WorldGen.genRand.Next(0, Main.maxTilesX);
						int j2 = WorldGen.genRand.Next((int)(Main.maxTilesY * .3f), (int)(Main.maxTilesY * .45f));
						WorldGen.OreRunner(i2, j2, WorldGen.genRand.Next(3, 4), WorldGen.genRand.Next(3, 8), (ushort)ModContent.TileType<Tiles.NightmareOreTile>());
					}

					for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
					{
						float value = (float)(k / (Main.maxTilesX * Main.maxTilesY * 2E-05));
						bool flag2 = false;
						int num = 0;
						while (!flag2)
						{
							if (TremorWorld.AddLunarRoots(WorldGen.genRand.Next(100, Main.maxTilesX - 100), WorldGen.genRand.Next((int)(Main.worldSurface - 5), Main.maxTilesY - 300)))
							{
								flag2 = true;
							}
							else
							{
								num++;
								if (num >= 10000)
								{
									flag2 = true;
								}
							}
						}
					}

					TremorWorld.Boss.Tremode.Downed();
				}
			}
		}

		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.Merchant && Main.bloodMoon)
			{
				shop.AddUniqueItem(ref nextSlot, ModContent.ItemType<RedPuzzleFragment>());
				nextSlot++;
			}
		}

		public override void SetDefaults(NPC npc)
		{
			if (npc.type == NPCID.Bunny)
			{
				npc.lifeMax = 10;
			}

			if (npc.type == NPCID.PossessedArmor)
			{
				npc.lifeMax = 280;
			}

			if (npc.type == NPCID.Wraith)
			{
				npc.lifeMax = 200;
			}

			if (npc.type == NPCID.ToxicSludge)
			{
				npc.lifeMax = 175;
			}

			if (npc.type == NPCID.Tim)
			{
				npc.lifeMax = 250;
			}

			if (npc.type == NPCID.Piranha)
			{
				npc.lifeMax = 35;
			}

			if (npc.type == NPCID.CaveBat)
			{
				npc.lifeMax = 22;
			}

			if (npc.type == NPCID.GiantBat)
			{
				npc.lifeMax = 150;
			}

			if (npc.type == NPCID.ArmoredSkeleton)
			{
				npc.lifeMax = 300;
			}

			if (npc.type == NPCID.SkeletonArcher)
			{
				npc.lifeMax = 250;
			}

			if (npc.type == NPCID.BlueJellyfish && Main.hardMode)
			{
				npc.catchItem = 2436;
			}

			if (npc.type == NPCID.GreenJellyfish && Main.hardMode)
			{
				npc.catchItem = 2437;
			}

			if (npc.type == NPCID.PinkJellyfish && Main.hardMode)
			{
				npc.catchItem = 2438;
			}

			//if(Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.CursedCoinBuff>()) != -1 && Main.rand.Next(50) == 0) 
			//{ 
			//npc.color = new Color(255, 255, 0, 100); 
			//npc.displayName = ("Luxuriant "+npc.displayName); 
			//npc.value = (float)(npc.value * 10f); 
			//}  

			if (NPC.downedMoonlord && npc.boss == false && npc.townNPC == false && npc.type >= NPCID.None && npc.type <= NPCID.Count)
			{
				npc.lifeMax *= 2;
				npc.defense *= 2;
			}
		}
	}
}