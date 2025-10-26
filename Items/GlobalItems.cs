using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Cursed;
using Tremor.Items.Flesh;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class GlobalItems : GlobalItem
	{
		public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
		{
			switch (item.type)
			{
				case ItemID.DestroyerBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Destructor>(), 6));
					break;
				case ItemID.SkeletronPrimeBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<PrimeBlade>(), 6));
					break;
				case ItemID.WallOfFleshBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<PieceofFlesh>(), 2, 8, 17));
					break;
				case ItemID.SkeletronBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CursedSoul>(), 1, 1, 5));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TearsofDeath>(), 1, 1, 3));
					break;
				case ItemID.GolemBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<GolemCore>(), 2));
					break;
				case ItemID.EyeOfCthulhuBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<EyeMonolith>(), 5));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<MonsterTooth>(), 4));
					break;
				case ItemID.PlanteraBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<EssenseofJungle>(), 2, 2, 3));
					break;
				case ItemID.MoonLordBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<MultidimensionalFragment>(), 2, 6, 12));
					break;
				case ItemID.QueenBeeBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<YellowPuzzleFragment>(), 3));
					break;
				case ItemID.TwinsBossBag:
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<MechaSprayer>(), 6));
					break;
			}

			if (!ItemID.Sets.PreHardmodeLikeBossBag[item.type] && ItemID.Sets.BossBag[item.type])
			{
				if (Main.rand.NextBool(30))
				{
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HummerHelmet>()));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HummerBreastplate>()));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HummerGreaves>()));
				}

				if (Main.rand.NextBool(30))
				{
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ZerokkHead>()));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ZerokkBody>()));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ZerokkLegs>()));
				}

				if (Main.rand.NextBool(30))
				{
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CursedKnightHelmet>()));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CursedKnightBreastplate>()));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CursedKnightGreaves>()));
				}

				if (Main.rand.NextBool(42))
				{
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SpinalMask>()));
				}
			}
		}

	}
}
