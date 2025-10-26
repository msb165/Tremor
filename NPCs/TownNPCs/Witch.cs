using System.Linq;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor;
using Tremor.Items;
using Tremor.Items.Plague;
using Tremor.Projectiles;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Witch:TremorModNPC
	{
		public override string Texture => $"{typeof(Witch).NamespaceToPath()}/Witch";

		//public override string[] AltTextures => new[] { $"{typeof(Witch).NamespaceToPath()}/Witch" };

		//public override bool Autoload(ref string name)
		//{
		//	name = "Witch";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Witch");
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
			=> Main.player.Any(player => !player.dead && player.inventory.Any(item => item != null && item.type == ItemID.GoodieBag));

		private readonly List<string> _names = new List<string>
		{
			"Circe",
			"Kikimora:2",
			"Morgana",
			"Hecate"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new[]
		{
			"<cackle> Welcome dearies! I hope you don't mind the body parts. I was just cleaning up.",
			"Eye of a newt! Tongue of a cat! Blood of a dryad... a little more blood.",
			"Don't pull my nose! It's not a mask!",
			"The moon has a secret dearies! One that you'll know soon enough!",
			"This is halloween! Or is it?",
			"Blood for the blood moon! Skulls for the skull cap... Or was it something else?"
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
			shop.Add(ModContent.ItemType<PlagueMask>());
			shop.Add(ModContent.ItemType<PlagueRobe>());
			shop.Add(ModContent.ItemType<SacrificalScythe>());
			shop.Add(ModContent.ItemType<Scarecrow>());

			if (NPC.downedBoss1)
				shop.Add(ModContent.ItemType<BoomSpear>());
			if (NPC.downedBoss2)
				shop.Add(ModContent.ItemType<BlackRose>());
			if (NPC.downedBoss3)
				shop.Add(ModContent.ItemType<Pumpspell>());
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
			projType = ModContent.ProjectileType<PumpkinPro>();
			attackDelay = 2;
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
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"WitchGore{i + 1}"), 1f);
			}
		}
	}
}