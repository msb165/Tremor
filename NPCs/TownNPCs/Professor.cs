using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor.Items;
using Tremor.Items.Alien;
using Tremor.Items.Ancient;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Professor:TremorModNPC
	{
		public override string Texture => $"{typeof(Professor).NamespaceToPath()}/Professor";

		//public override string[] AltTextures => new[] { $"{typeof(Professor).NamespaceToPath()}/Professor" };

		//public override bool Autoload(ref string name)
		//{
		//	name = "Professor";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Professor");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 5;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 1000;
			NPCID.Sets.AttackType[npc.type] = 1;
			NPCID.Sets.AttackTime[npc.type] = 30;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 24;
			npc.height = 46;
			npc.aiStyle = 7;
			npc.damage = 40;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			AnimationType = NPCID.GoblinTinkerer;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs)/* tModPorter Suggestion: Copy the implementation of NPC.SpawnAllowed_Merchant in vanilla if you to count money, and be sure to set a flag when unlocked, so you don't count every tick. */
			=> Main.hardMode && Main.player.Any(player => !player.dead);

		private readonly List<string> _names = new List<string>
		{
			"James:2",
			"Harold:2",
			"Steven",
			"David",
			"John",
			"Brus Bunner",
			"Alfred"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new[]
		{
			"Don't mind my appearance. This is just the result of a failed experiment.",
			"Do you have a carrot? Oh, never mind.",
			"Imagine that in all those rabbits that you have killed were imprisoned soul of common people! Just think about it...",
			"Someday we'll all feel the cold embrace of death. Bring me some more carrot soup before this happens.",
			"Magic allows you to do what cannot be done scientifically. The main thing is not to overdo it, if you know what I mean.",
			"I  don't like people that like how wizards 'magically' grab rabbits out of their magic hats. It's horrible!",
			"I studied the anomalies in this world a long time ago. During this time, I became the anomaly myself. Funny."
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
			shop.Add(1337);
			shop.Add(ModContent.ItemType<KeyMold>());
			shop.Add(ModContent.ItemType<LifeMachine>());
			shop.Add(ModContent.ItemType<AncientTechnology>());
			shop.Add(ModContent.ItemType<BagofDust>());

			if (NPC.downedAncientCultist)
				shop.Add(ModContent.ItemType<ManaGenerator>());
			if (NPC.downedMechBossAny)
				shop.Add(ModContent.ItemType<ChaoticAmplifier>());
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 40;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 5;
			randExtraCooldown = 5;
		}

		public override void DrawTownAttackGun(ref Texture2D item, ref Rectangle itemFrame, ref float scale, ref int horizontalHoldoutOffset)/* tModPorter Note: closeness is now horizontalHoldoutOffset, use 'horizontalHoldoutOffset = Main.DrawPlayerItemPos(1f, itemtype) - originalClosenessValue' to adjust to the change. See docs for how to use hook with an item type. */ //Allows you to customize how this town NPC's weapon is drawn when this NPC is shooting (this NPC must have an attack type of 1). Scale is a multiplier for the item's drawing size, item is the ID of the item to be drawn, and closeness is how close the item should be drawn to the NPC.
		{
			scale = 1f;
			Main.GetItemDrawFrame(ModContent.ItemType<AlienBlaster>(), out Texture2D itemTexture, out Rectangle itemFrame1);
			item = itemTexture;
			horizontalHoldoutOffset = 14;
		}
		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
		{
			projType = 440;
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)//Allows you to determine the speed at which this town NPC throws a projectile when it attacks. Multiplier is the speed of the projectile, gravityCorrection is how much extra the projectile gets thrown upwards, and randomOffset allows you to randomize the projectile's velocity in a square centered around the original velocity
		{
			multiplier = 7f;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				for (int i = 0; i < 3; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"ProfessorGore{i + 1}"), 1f);
			}
		}
	}
}