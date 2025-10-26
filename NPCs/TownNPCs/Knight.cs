using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor.Items;
using Tremor.Items.Chain;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Knight:TremorModNPC
	{
		public override string Texture => $"{typeof(Knight).NamespaceToPath()}/Knight";

		//public override string[] AltTextures => new[] { $"{typeof(Knight).NamespaceToPath()}/Knight" };

		//public override bool Autoload(ref string name)
		//{
		//	name = "Knight";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Knight");
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
			npc.width = 30;
			npc.height = 44;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			AnimationType = NPCID.GoblinTinkerer;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs)/* tModPorter Suggestion: Copy the implementation of NPC.SpawnAllowed_Merchant in vanilla if you to count money, and be sure to set a flag when unlocked, so you don't count every tick. */
			=> Main.player.Any(player => !player.dead);

		private readonly List<string> _names = new List<string>
		{
			"Wheatly",
			"Daniel:3",
			"Crox",
			"Geralt:2",
			"Roland",
			"Hodor:4"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new[]
		{
			"Well met, brave adventurer.",
			"A balanced weapon can mean the difference between victory and defeat.",
			"I am not overly fond of the bovine hordes. Best to leave them alone, really.",
			"Do you have a weapon? Needs about 20% more coolness!",
			"Hail and good morrow my Liege!",
			"I was in a strange castle one day. There were mechanical things saying EXTERMINATE. Were they your minions?",
			"Have you ever met a knight whose name is Sir Uncle Slime? He is a good friend of mine."
		}.ToWeightedCollection();

		public override string GetChat()
			=> Name == "Hodor" ? Name : _chats.Get();

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
			shop.Add(ModContent.ItemType<ThrowingAxe>());
			shop.Add(ModContent.ItemType<RustySword>());
			shop.Add(ModContent.ItemType<RipperKnife>());

			if (NPC.downedBoss1)
			{
				shop.Add(ModContent.ItemType<TombRaider>());
				shop.Add(ModContent.ItemType<SpikeShield>());
				shop.Add(ModContent.ItemType<ChainCoif>());
				shop.Add(ModContent.ItemType<Chainmail>());
				shop.Add(ModContent.ItemType<ChainGreaves>());
			}
			if (NPC.downedBoss2)
			{
				shop.Add(ModContent.ItemType<TwilightHorns>());
				shop.Add(ModContent.ItemType<ToxicRazorknife>());
			}
			if (NPC.downedBoss3)
			{
				shop.Add(ModContent.ItemType<NecromancerClaymore>());
				shop.Add(ModContent.ItemType<Shovel>());
			}

			if (Main.hardMode)
			{
				shop.Add(ModContent.ItemType<GoldenThrowingAxe>());

				if (Main.bloodMoon)
					shop.Add(ModContent.ItemType<Oppressor>());
			}
			if (NPC.downedMechBossAny)
			{
				shop.Add(ModContent.ItemType<PrizmaticSword>());
			}
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 25;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ModContent.ProjectileType<Projectiles.ThrowingAxe>();
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

				for (int i = 0; i < 3; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"KnightGore{i + 1}"), 1f);
			}
		}
	}
}