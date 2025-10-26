using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor;
using Tremor.Items;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Sorcerer:TremorModNPC
	{
		public override string Texture => $"{typeof(Sorcerer).NamespaceToPath()}/Sorcerer";

		//public override string[] AltTextures => new[] { $"{typeof(Sorcerer).NamespaceToPath()}/Sorcerer" };

		//public override bool Autoload(ref string name)
		//{
		//	name = "Sorcerer";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sorcerer");
			Main.npcFrameCount[npc.type] = 26;
			NPCID.Sets.ExtraFramesCount[npc.type] = 5;
			NPCID.Sets.AttackFrameCount[npc.type] = 5;
			NPCID.Sets.DangerDetectRange[npc.type] = 1000;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 30;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 32;
			npc.height = 54;
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
			=> Main.player.Any(player => !player.dead);

		private readonly List<string> _names = new List<string>
		{
			"Merdok:2",
			"Avalon:3",
			"Aron",
			"Harry",
			"Edgar",
			"Marco"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new[]
		{
			"You'll never find me trapped underground.",
			"Sorcery is all about control. It's different from magic in that it requires symbols and fetishes.",
			"I can share the magic with you for free. Well... Almost free.",
			"Sorry. I don't do parties.",
			"Don't touch that if you want to keep your hand. It's still quite unstable.",
			"I want to get the rabbit out of the hat! Do you want it? You don't want a rabbit? Seriously!?"
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
			shop.Add(ItemID.Bunny);
			shop.Add(ModContent.ItemType<BurningTome>());
			shop.Add(ModContent.ItemType<RazorleavesTome>());
			shop.Add(ModContent.ItemType<EnchantedShield>());
			if (NPC.downedBoss1)
			{
				shop.Add(ModContent.ItemType<StarfallTome>());
				shop.Add(ModContent.ItemType<GoldenHat>());
				shop.Add(ModContent.ItemType<GoldenRobe>());
			}
			if (NPC.downedBoss2)
			{
				shop.Add(ModContent.ItemType<LightningTome>());
				shop.Add(ModContent.ItemType<Bloomstone>());
			}

			if (Main.hardMode)
				shop.Add(ModContent.ItemType<ManaDagger>());
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 22;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = 124;
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
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"SorcererGore{i + 1}"), 1f);
			}
		}
	}
}