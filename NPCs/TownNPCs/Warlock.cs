using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor;
using Tremor.Items;
using Tremor.Items.Chain;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Warlock:TremorModNPC
	{
		public override string Texture => $"{typeof(Warlock).NamespaceToPath()}/Warlock";

		//public override string[] AltTextures => new[] { $"{typeof(Warlock).NamespaceToPath()}/Warlock" };

		//public override bool Autoload(ref string name)
		//{
		//	name = "Warlock";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Warlock");
			Main.npcFrameCount[npc.type] = 26;
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
			npc.width = 40;
			npc.height = 52;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.knockBackResist = 0.5f;
			AnimationType = NPCID.Guide;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs)/* tModPorter Suggestion: Copy the implementation of NPC.SpawnAllowed_Merchant in vanilla if you to count money, and be sure to set a flag when unlocked, so you don't count every tick. */
			=> NPC.downedBoss2 && Main.player.Any(player => !player.dead);

		private readonly List<string> _names = new List<string>
		{
			"Azazel:2",
			"Baphomet",
			"Vaal:3",
			"Dis",
			"Nisroke",
			"Sabnak"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new[]
		{
			"..."
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
			shop.Add(ModContent.ItemType<StrongBelt>());

			if (NPC.downedBoss3)
				shop.Add(ModContent.ItemType<BallnChain>());

			if (WorldGen.crimson)
			{
				shop.Add(ModContent.ItemType<ViciousHelmet>());
				shop.Add(ModContent.ItemType<ViciousChestplate>());
				shop.Add(ModContent.ItemType<ViciousLeggings>());
			}
			else
			{
				shop.Add(ModContent.ItemType<VileHelmet>());
				shop.Add(ModContent.ItemType<VileChestplate>());
				shop.Add(ModContent.ItemType<VileLeggings>());
			}

			if (Main.hardMode)
			{
				shop.Add(ModContent.ItemType<Necronomicon>());
				shop.Add(ModContent.ItemType<Zephyrhorn>());
			}

			if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
				shop.Add(ModContent.ItemType<NecroWarhammer>());
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = 270;
			attackDelay = 5;
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

				for (int i = 0; i < 3; i++)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"WarlockGore{i + 1}"), 1f);
			}
		}
	}
}