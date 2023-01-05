using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Alchemist;

namespace Tremor
{
	public class NPCDrops : GlobalNPC
	{
		public static void Init()
		{
			VanillaWoFWeapons = new int[]
			{
				ItemID.LaserRifle,
				ItemID.BreakerBlade,
				ItemID.ClockworkAssaultRifle
			};

			VanillaWoFEmblems = new int[]
			{
				ItemID.WarriorEmblem,
				ItemID.RangerEmblem,
				ItemID.SorcererEmblem,
				ItemID.SummonerEmblem,
				ModContent.ItemType<AlchemistEmblem>(),
				ModContent.ItemType<ThrowerEmblem>()
			};
		}

		internal static int[] VanillaWoFWeapons;
		internal static int[] VanillaWoFEmblems;

		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			switch (npc.type)
			{
				case NPCID.WallofFlesh:
					bool dropEmblemAlchemist = Main.rand.NextBool(1, 5);
					if (dropEmblemAlchemist)
					{
						if (Main.rand.NextBool(1, 7))
						{
							Item.NewItem(null, npc.position, npc.width, npc.height, ItemID.FleshMask);
						}
						if (Main.rand.NextBool(1, 7))
						{
							Item.NewItem(null, npc.position, npc.width, npc.height, 1365);
						}
						Item.NewItem(null, npc.position, npc.width, npc.height, Utils.SelectRandom(Main.rand, VanillaWoFEmblems));
						Item.NewItem(null, npc.position, npc.width, npc.height, Utils.SelectRandom(Main.rand, VanillaWoFWeapons));
						Item.NewItem(null, npc.position, npc.width, npc.height, ItemID.GoldCoin, Main.rand.Next(6, 10));
					}
					break;
			}
		}
	}

	public class BossBags : GlobalItem
	{
		public override bool PreOpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "bossBag")
			{
				switch (arg)
				{
					case ItemID.WallOfFleshBossBag:
						bool dropEmblemAlchemist = Main.rand.NextBool(1, 5);
						if (dropEmblemAlchemist)
						{
							if (!player.extraAccessory)
							{
								player.QuickSpawnItem(null, ItemID.DemonHeart);
							}
							if (Main.rand.NextBool(1, 7))
							{
								player.QuickSpawnItem(null, ItemID.FleshMask);
							}
							player.QuickSpawnItem(null, Utils.SelectRandom(Main.rand, NPCDrops.VanillaWoFEmblems));
							player.QuickSpawnItem(null, Utils.SelectRandom(Main.rand, NPCDrops.VanillaWoFWeapons));
							player.QuickSpawnItem(null, ItemID.GoldCoin, Main.rand.Next(6, 10));
							return false;
						}
						break;
				}
			}
			return true;
		}
	}
}

