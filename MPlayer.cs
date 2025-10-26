using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Afterlife;
using Tremor.Items.Argite;
using Tremor.Items.Berserker;
using Tremor.Items.Brass;
using Tremor.Items.Chaos;
using Tremor.Items.Crystal;
using Tremor.Items.Flesh;
using Tremor.Items.Fungus;
using Tremor.Items.Harpy;
using Tremor.Items.Invar;
using Tremor.Items.Magmonium;
using Tremor.Items.Nano;
using Tremor.Items.Nightingale;
using Tremor.Items.Orcish;
using Tremor.Items.Sandstone;

namespace Tremor
{
	// Todo: transfer more to a general class
	public class MPlayer : ModPlayer
	{
		public static MPlayer GetModPlayer(Player player) => player.GetModPlayer<MPlayer>();

		// Buffs and debuffs
		public bool fragileContiion;

		//TODO: [Skipped for 1.4] Add proper custom damage type for this
		// Alchemist
		public float alchemicalDamage;
		public float alchemicalKbAddition;
		public float alchemicalKbMult;
		public int alchemicalCrit;

		// Undocumented
		public bool pyro;
		public bool nitro;
		public bool spirit;
		public bool enchanted;
		public bool glove;
		public bool core;
		public bool novaAura;
		public bool novaSet;
		public bool novaHelmet;
		public bool novaChestplate;

		public override void ResetEffects()
		{
			// Buffs and debuffs
			fragileContiion = false;

			// Alchemist
			alchemicalDamage = 1f;
			alchemicalKbAddition = 0f;
			alchemicalKbMult = 1f;
			alchemicalCrit = 0;

			// Undocumented
			pyro = false;
			nitro = false;
			spirit = false;
			enchanted = false;
			glove = false;
			core = false;
			novaAura = false;
			novaSet = false;
			novaHelmet = false;
			novaChestplate = false;
		}

		public override void PostUpdateMiscEffects()
		{
			// Reset conditions
			if (fragileContiion)
				Player.statDefense *= 0;
		}

		public override void OnEnterWorld()
		{
			// switch this bool to log
			if (false)
			{
				// some random sheet to log armor recipes
				// cuz im  lazy
				// poops out the wiki format for armor sets recipes
				// does not support 3 hat variants, or assumes all hats use the same recipes
				// (deviant hat recipes not allowed), put in 1 hat
				// WorkBenches => Work Bench
				// Anvils => Iron Anvil / Lead Anvil
				// MythrilAnvil => Mythril Anvil / Orihalcum Anvil
				var armors = new[]
				{
					new[]
					{
						ModContent.ItemType<InvarHat>(),
						ModContent.ItemType<InvarBreastplate>(),
						ModContent.ItemType<InvarGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<HarpyHelmet>(),
						ModContent.ItemType<HarpyChestplate>(),
						ModContent.ItemType<HarpyLeggings>(),
					},
					new[]
					{
						ModContent.ItemType<ArgiteHelmet>(),
						ModContent.ItemType<ArgiteBreastplate>(),
						ModContent.ItemType<ArgiteGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<NightingaleHood>(),
						ModContent.ItemType<NightingaleChestplate>(),
						ModContent.ItemType<NightingaleGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<OrcishHelmet>(),
						ModContent.ItemType<OrcishBreastplate>(),
						ModContent.ItemType<OrcishGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<FungusHelmet>(),
						ModContent.ItemType<FungusBreastplate>(),
						ModContent.ItemType<FungusGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<FleshHelmet>(),
						ModContent.ItemType<FleshBreastplate>(),
						ModContent.ItemType<FleshGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<CrystalHelmet>(),
						ModContent.ItemType<CrystalChestplate>(),
						ModContent.ItemType<CrystalGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<LuxoriousHelmet>(),
						ModContent.ItemType<LuxoriousBreastplate>(),
						ModContent.ItemType<LuxoriousLeggings>(),
					},
					new[]
					{
						ModContent.ItemType<AfterlifeHood>(),
						ModContent.ItemType<AfterlifeBreastplate>(),
						ModContent.ItemType<AfterlifeLeggings>(),
					},
					new[]
					{
						ModContent.ItemType<NanoHelmet>(),
						ModContent.ItemType<NanoBreastplate>(),
						ModContent.ItemType<NanoGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<MagmoniumHelmet>(),
						ModContent.ItemType<MagmoniumBreastplate>(),
						ModContent.ItemType<MagmoniumGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<SandStoneHelmet>(),
						ModContent.ItemType<SandStoneBreastplate>(),
						ModContent.ItemType<SandStoneGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<ChaosHelmet>(),
						ModContent.ItemType<ChaosBreastplate>(),
						ModContent.ItemType<ChaosGreaves>(),
					},
					new[]
					{
						ModContent.ItemType<BrassHelmet>(),
						ModContent.ItemType<BrassHeadgear>(),
						ModContent.ItemType<BrassMask>(),
					},
					new[]
					{
						ModContent.ItemType<BerserkerHelmet>(),
						ModContent.ItemType<BerserkerChestplate>(),
						ModContent.ItemType<BerserkerGreaves>(),
					},
				};

				//ErrorLogger.ClearLog();
				
				foreach (var armor in armors)
				{
					Item item = new Item(); // item used for initializing

					Mod.Logger.Info("==========");
					Mod.Logger.Info("Combined recipe for: " + string.Join(", ", armor.Select(x =>
					{
						item.SetDefaults(x);
						return item.Name;
					})));
					Mod.Logger.Info("==========");

					var reqItems = new List<Item>();
					var reqTiles = new List<int>();
					var reqTileNames = new List<string>();

					// loop pieces
					foreach (int piece in armor)
					{
						var recipes = Main.recipe.Where(x => x.createItem.type == piece);
						foreach (Recipe recipe in recipes)
						{
							reqItems = reqItems.Concat(recipe.requiredItem).ToList();
							reqTiles = reqTiles.Concat(recipe.requiredTile).ToList();
						}
					}

					// combine stacks
					var duplicateItems = reqItems.GroupBy(x => x.type).Where(x => x.Count() > 1).Select(x => x);
					var combItems = TremorUtils.DistinctBy(reqItems, x => x.type).ToList();
					foreach (var grouping in duplicateItems)
					{
						var reqItem = combItems.FirstOrDefault(x => x.type == grouping.Key);
						if (reqItem != null)
						{
							reqItem.stack = reqItems.Where(x => x.type == grouping.Key).Sum(x => x.stack);
						}
					}
					reqItems = new List<Item>(combItems);
					reqTiles = reqTiles.Distinct().ToList();

					// get non empty entries
					reqItems = reqItems.Where(x => !x.IsAir).ToList();
					reqTileNames = reqTiles.Where(x => x > 0).Select(x => typeof(TileID).FindNameByConstant((ushort) x)).ToList();
					int i = reqTileNames.IndexOf("Anvils");
					if (i != -1)
					{
						reqTileNames.RemoveAt(i);
						reqTileNames.Add("Iron Anvil");
						reqTileNames.Add("Lead Anvil");
					}
					i = reqTileNames.IndexOf("WorkBenches");
					if (i != -1)
					{
						reqTileNames.RemoveAt(i);
						reqTileNames.Add("Work Bench");
					}
					i = reqTileNames.IndexOf("OrichalcumAnvil");
					if (i != -1)
					{
						reqTileNames.RemoveAt(i);
						reqTileNames.Add("Orichalcum Anvil");
					}
					i = reqTileNames.IndexOf("MythrilAnvil");
					if (i != -1)
					{
						reqTileNames.RemoveAt(i);
						reqTileNames.Add("Mythril Anvil");
						reqTileNames.Add("Orichalcum Anvil");
					}

					// make strings, log
					string items = "* " + string.Join(" + ", reqItems.Select(x => $"{x.stack} {{{{item link|{x.Name}}}}}"));
					string tiles = "* Crafted at " + string.Join(" / ", reqTileNames.Select(x => $"{{{{item link|{x}}}}}"));
					Mod.Logger.Info($"{items}\n{tiles}");
					Mod.Logger.Info("==========\n");
				}
			}
		}
	}
}
