using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Cursed;
using Tremor.Items.Flesh;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class GlobalItems : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "bossBag")
			{
				if (arg == ItemID.DestroyerBossBag && Main.rand.NextBool(6))
				{
					player.QuickSpawnItem(ModContent.ItemType<Destructor>());
				}

				if (arg == ItemID.SkeletronPrimeBossBag && Main.rand.NextBool(6))
				{
					player.QuickSpawnItem(ModContent.ItemType<PrimeBlade>());
				}
				if (arg == ItemID.WallOfFleshBossBag && Main.rand.NextBool())
				{
					player.QuickSpawnItem(ModContent.ItemType<PieceofFlesh>(), Main.rand.Next(8, 17));
				}
				if (arg == ItemID.SkeletronBossBag && Main.rand.NextBool())
				{
					player.QuickSpawnItem(ModContent.ItemType<CursedSoul>(), Main.rand.Next(1, 5));
				}
				if (arg == ItemID.GolemBossBag && Main.rand.NextBool())
				{
					player.QuickSpawnItem(ModContent.ItemType<GolemCore>());
				}
				if (arg == ItemID.EyeOfCthulhuBossBag && Main.rand.NextBool(5))
				{
					player.QuickSpawnItem(ModContent.ItemType<EyeMonolith>());
				}
				if (arg == ItemID.EyeOfCthulhuBossBag && Main.rand.NextBool(4))
				{
					player.QuickSpawnItem(ModContent.ItemType<MonsterTooth>());
				}

				if (arg == ItemID.PlanteraBossBag && Main.rand.NextBool())
				{
					player.QuickSpawnItem(ModContent.ItemType<EssenseofJungle>(), Main.rand.Next(2, 3));
				}

				//if (arg == ItemID.FishronBossBag && Main.rand.NextBool(6))
				//{
				//	player.QuickSpawnItem(ModContent.ItemType<DukesCannon>());
				//}

				if (arg == ItemID.MoonLordBossBag && Main.rand.NextBool())
				{
					player.QuickSpawnItem(ModContent.ItemType<MultidimensionalFragment>(), Main.rand.Next(6, 12));
				}

				if (arg == ItemID.SkeletronBossBag && Main.rand.NextBool())
				{
					player.QuickSpawnItem(ModContent.ItemType<TearsofDeath>(), Main.rand.Next(1, 3));
				}

				if (arg == ItemID.QueenBeeBossBag && Main.rand.NextBool(3))
				{
					player.QuickSpawnItem(ModContent.ItemType<YellowPuzzleFragment>());
				}

				if (arg == ItemID.TwinsBossBag && Main.rand.NextBool(6))
				{
					player.QuickSpawnItem(ModContent.ItemType<MechaSprayer>());
				}

				// Dev. Items
				if (Main.hardMode)
				{
					//if (Main.rand.Next(30) == 0)
					//{
					//	player.QuickSpawnItem(ModContent.ItemType<Zadum4iviiHelmet>());
					//	player.QuickSpawnItem(ModContent.ItemType<Zadum4iviiCuirass>());
					//	player.QuickSpawnItem(ModContent.ItemType<Zadum4iviiLeggings>());
					//}

					if (Main.rand.Next(30) == 0)
					{
						player.QuickSpawnItem(ModContent.ItemType<HummerHelmet>());
						player.QuickSpawnItem(ModContent.ItemType<HummerBreastplate>());
						player.QuickSpawnItem(ModContent.ItemType<HummerGreaves>());
					}

					if (Main.rand.Next(30) == 0)
					{
						player.QuickSpawnItem(ModContent.ItemType<ZerokkHead>());
						player.QuickSpawnItem(ModContent.ItemType<ZerokkBody>());
						player.QuickSpawnItem(ModContent.ItemType<ZerokkLegs>());
					}

					if (Main.rand.Next(30) == 0)
					{
						player.QuickSpawnItem(ModContent.ItemType<CursedKnightHelmet>());
						player.QuickSpawnItem(ModContent.ItemType<CursedKnightBreastplate>());
						player.QuickSpawnItem(ModContent.ItemType<CursedKnightGreaves>());
					}

					if (Main.rand.Next(42) == 0)
					{
						player.QuickSpawnItem(ModContent.ItemType<SpinalMask>());
					}
				}
			}
		}
	}
}
