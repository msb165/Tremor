using System.Linq;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor.Items;
using Tremor.Projectiles;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class ForgeMaster:TremorModNPC
	{
		public override string Texture => $"{typeof(ForgeMaster).NamespaceToPath()}/ForgeMaster";

		//public override string[] AltTextures => new[] { $"{typeof(ForgeMaster).NamespaceToPath()}/ForgeMaster" };

		//public override bool Autoload(ref string name)
		//{
		//	name = "Forge Master";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Forge Master");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 5;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 1000;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 30;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 28;
			npc.height = 48;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			AnimationType = NPCID.Guide;
		}
		
		public override bool CanTownNPCSpawn(int numTownNPCs)/* tModPorter Suggestion: Copy the implementation of NPC.SpawnAllowed_Merchant in vanilla if you to count money, and be sure to set a flag when unlocked, so you don't count every tick. */
		   => Main.player.Any(player => !player.dead && player.inventory.Any(item => item != null && item.type == ModContent.ItemType<JungleAlloy>()));

		private readonly List<string> _names = new List<string>
		{
			"Gefest:2",
			"Aule",
			"Agarorn:2",
			"Treak",
			"Haymer",
			"Golan"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new[]
		{
			"You can't lift my hammer? Not surprising! That's because you are not worthy!",
			"Strangely but nobody uses hammers for making bars. How do you just put ore into furnaces and get bars!? That is insane!",
			"Valar Morghulis! Oh wait, that's not the Braavos! Forget what I've said.",
			"What? You ask me who am I?! I am the son of the Vulcan and the Vulcan is the mighty anvilborn!",
			"My bars are better because I make them with my hammer. If you won't buy my bars I will make a bar from you.",
			"You wonder why people call me Forge Master!? What means you don't believe I'm the real Master of Forges!?",
			"Be careful when working with forges. I got burnt once when I was taking off a bar from it. That's why I'm wearing such armor!"
		}.ToWeightedCollection();

		public override string GetChat()
			=> _chats.Get();

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28].Value;
		}

		public override void OnChatButtonClicked(bool firstButton, ref string shopName)
		{
			if (firstButton)
			{
				shopName = "Shop";
			}
		}

		public override void ModifyActiveShop(string shopName, Item[] items)
		{
			NPCShop shop = new(Type);
			shop.Add(ModContent.ItemType<GreatAnvil>());

			if (Main.dayTime)
			{
				shop.Add(ItemID.CopperBar);
				shop.Add(ItemID.IronBar);
				shop.Add(ItemID.SilverBar);

				if (NPC.downedBoss2)
					shop.Add(ItemID.GoldBar);
				if (NPC.downedBoss3)
					shop.Add(ItemID.DemoniteBar);

				if (NPC.downedMechBossAny)
				{
					shop.Add(ItemID.CobaltBar);
					shop.Add(ItemID.MythrilBar);
					shop.Add(ItemID.AdamantiteBar);
				}
			}
			else
			{
				shop.Add(ItemID.TinBar);
				shop.Add(ItemID.LeadBar);
				shop.Add(ItemID.TungstenBar);

				if (NPC.downedBoss2)
					shop.Add(ItemID.PlatinumBar);
				if (NPC.downedBoss3)
					shop.Add(ItemID.CrimtaneBar);

				if (NPC.downedMechBossAny)
				{
					shop.Add(ItemID.PalladiumBar);
					shop.Add(ItemID.OrichalcumBar);
					shop.Add(ItemID.TitaniumBar);
				}
			}

			if (NPC.downedBoss2)
				shop.Add(ModContent.ItemType<PoisonRod>());
			if (NPC.downedBoss3)
			{
				shop.Add(ModContent.ItemType<BurningHammer>());
				shop.Add(ModContent.ItemType<PerfectBehemoth>());
			}
			if (NPC.downedPlantBoss)
				shop.Add(ItemID.HallowedBar);
			if (NPC.downedGolemBoss)
				shop.Add(ItemID.ChlorophyteBar);
			if (NPC.downedAncientCultist)
				shop.Add(ItemID.SpectreBar);

			if (Main.hardMode)
			{
				shop.Add(ModContent.ItemType<GoldenMace>());
				shop.Add(ItemID.HellstoneBar);
			}
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 22;
			knockback = 3f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ModContent.ProjectileType<BurningHammerPro>();
			attackDelay = 4;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				for (int i = 0; i < 4; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"BlackSmithGore{i + 1}"), 1f);
			}
		}
	}
}