using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor.Items;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Undertaker:TremorModNPC
	{
		public override string Texture => $"{typeof(Undertaker).NamespaceToPath()}/Undertaker";

		//public override string[] AltTextures => new[] { $"{typeof(Undertaker).NamespaceToPath()}/Undertaker" };

		//public override bool Autoload(ref string name)
		//{
		//	name = "Undertaker";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Undertaker");
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
			AnimationType = NPCID.Guide;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs)/* tModPorter Suggestion: Copy the implementation of NPC.SpawnAllowed_Merchant in vanilla if you to count money, and be sure to set a flag when unlocked, so you don't count every tick. */
			=> TremorWorld.Boss.Trinity.IsDowned() && Main.player.Any(player => !player.dead);

		private readonly List<string> _names = new List<string>
		{
			"Tenner",
			"Geyer",
			"Cleve",
			"Ferron",
			"Gasper",
			"Spots",
			"Hargon:3"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new[]
		{
			"Don't worry. Nobody will get out of the coffin that I have made.",
			"Are you afraid of ghosts? I'm not. But the ghosts are afraid of me.",
			"If you need some help then feel free to ask me. I have a lot of undead things on my side.:3",
			"What will you prefer to do if this day will be your last day?",
			"Our life is a challenge. To make it easier - buy my stuff.",
			"Don't worry. I'm not a vampire even my eyes are red and my skin is of a strange color.",
			"Do you prefer blood or tomato juice?"
		}.ToWeightedCollectionWithWeight();

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
			shop.Add(ModContent.ItemType<Skullheart>());
			shop.Add(ModContent.ItemType<SpearofJustice>());
			shop.Add(ModContent.ItemType<TheGhostClaymore>());
			if (!Main.dayTime)
				shop.Add(ModContent.ItemType<LivingTombstone>());
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 150;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = 645;
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
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"TheUndertakerGore{i+1}"), 1f);
			}
		}
	}
}