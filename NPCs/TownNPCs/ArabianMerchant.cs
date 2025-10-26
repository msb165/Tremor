using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor.Items;
using Tremor.Items.Desert;
using Tremor.Items.Sandstone;
using Tremor.Projectiles;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class ArabianMerchant:TremorModNPC
	{
		public override string Texture => typeof(ArabianMerchant).FullNameToPath();

		//public override string[] AltTextures => new[]{typeof(ArabianMerchant).FullNameToPath()};

		//public override bool Autoload(ref string name)
		//{
		//	name = "Arabian Merchant";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Arabian Merchant");
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
			npc.width = 28;
			npc.height = 48;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			//npc.homeless = true;
			//npc.active = false;
			AnimationType = NPCID.Guide;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs)/* tModPorter Suggestion: Copy the implementation of NPC.SpawnAllowed_Merchant in vanilla if you to count money, and be sure to set a flag when unlocked, so you don't count every tick. */
			=> TremorWorld.Boss.Rukh.IsDowned() && Main.player.Any(player => !player.dead);

		private readonly List<string> _names = new List<string>
		{
			"Badruddin:2",
			"Galib",
			"Salavat",
			"Zafar",
			"Valid",
			"Tunak",
			"Nadim:3"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new[]
		{
			("Salam aleykum! Do you need anything?",1),
			("I got some sand in my pockets. I think throwing it will hurt your eyes.", 2),
			("My wear was absolutely white long time ago. Maybe I should wash it with this perfect yellow water?", 2),
			("There are stories about what happened in the sands of this desert. But I won't tell you anything.", .5),
			("In case something will happen with me... I bequeath you all my sand.", .75),
			("The sands are telling me that... That... Ugh... That you will buy everything!", 3),
			("The sands are moving... Be careful or you will be sucked into unknown depths!", 1)
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
			shop.Add(ModContent.ItemType<GenieLamp>());
			shop.Add(ModContent.ItemType<JavaHood>());
			shop.Add(ModContent.ItemType<JavaRobe>());
			shop.Add(ModContent.ItemType<SandstoneRing>());

			if (NPC.downedBoss1)
			{
				shop.Add(ModContent.ItemType<FossilSugar>());
				shop.Add(ModContent.ItemType<DesertCrown>());
			}
			if (NPC.downedBoss2)
			{
				shop.Add(ItemID.BoneJavelin);
				shop.Add(ItemID.BoneDagger);
			}

			if (Main.hardMode)
				shop.Add(ModContent.ItemType<DesertEagle>());
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 30;
			knockback = 3f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ModContent.ProjectileType<Sand>();
			attackDelay = 4;
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
				npc.NewItem((short)ModContent.ItemType<WhiteTurban>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				for (int i = 0; i < 3; i++)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"ArabianMerchantGore{i + 1}"), 1f);
			}
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}