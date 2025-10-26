using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor.Items;
using Tremor.Items.Alchemist;
using Tremor.Items.Alchemist.Flasks;
using Tremor.Projectiles.Alchemic;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Alchemist : TremorModNPC
	{
		public override string Texture => $"{typeof(Alchemist).NamespaceToPath()}/Alchemist";

		//public override string[] AltTextures => new[] { $"{typeof(Alchemist).NamespaceToPath()}/Alchemist" };

		//public override string Name => "Alchemist";

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Alchemist");
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
			=> NPC.downedBoss1 && Main.player.Any(player => !player.dead);

		private readonly List<string> _names = new List<string>
		{
			"Rizo:2",
			"Albert",
			"Bernando",
			"Seefeld",
			"Raymond",
			"Paracelsus:3",
			"Nerxius:2"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new WeightedRandom<string>(
			"Love is just a chain of chemical reactions. So that you know.".ToWeightedTuple(2),
			"If you wanna know, it was hard to press these gel cubes.".ToWeightedTuple(),
			"Wanna try something new? I think you may be interested in... BOOM FLASKS!".ToWeightedTuple(3),
			"The man who passes the sentence should throw the flask...".ToWeightedTuple(2),
			"I'm gonna have to throw EVERY SINGLE FLASK in this house!".ToWeightedTuple(),
			"What? You don't like my hairstyle? Your isn't better.".ToWeightedTuple(.5),
			"If you think that I'm a terrorist just because I sell exploding flasks? You're wrong. There are even worse people who sell worse things.".ToWeightedTuple()
		);

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

		public override void AddShops()
		{
			NPCShop shop = new(Type);
			shop.Add(ModContent.ItemType<BasicFlask>());
			shop.Add(ModContent.ItemType<HazardousChemicals>());
			shop.Add(ItemID.StinkPotion);
			shop.Add(ItemID.LovePotion);

			shop.Add(ModContent.ItemType<Pyro>(), new Condition("Mods.Tremor.Conditions.Alchemaster.IsDowned", () => TremorWorld.Boss.Alchemaster.IsDowned()));

			shop.Add(ModContent.ItemType<BigHealingFlack>(), Condition.TimeDay, Condition.Hardmode);
			shop.Add(ModContent.ItemType<BigManaFlask>(), Condition.TimeNight, Condition.Hardmode);
			shop.Add(ModContent.ItemType<BlackCauldron>(), Condition.Hardmode);
			shop.Add(ModContent.ItemType<LesserVenomFlask>(), Condition.Hardmode);
			shop.Add(ModContent.ItemType<ConcentratedTincture>(), Condition.Hardmode);
			shop.Add(ModContent.ItemType<LesserHealingFlack>(), Condition.TimeDay);
			shop.Add(ModContent.ItemType<LesserManaFlask>(), Condition.TimeNight);

			shop.Add(ModContent.ItemType<HealthSupportFlask>());
			shop.Add(ModContent.ItemType<ManaSupportFlask>());

			shop.Add(ModContent.ItemType<FreezeFlask>(), Condition.InSnow);
			shop.Add(ModContent.ItemType<LesserPoisonFlask>(), Condition.InJungle);

			shop.Add(ModContent.ItemType<BoomFlask>(), Condition.DownedEyeOfCthulhu);
			if (NPC.downedBoss2)
			{
				shop.Add(ModContent.ItemType<Nitro>());
				shop.Add(ModContent.ItemType<BurningFlask>());
			}
			if (NPC.downedBoss3)
				shop.Add(ModContent.ItemType<GoldFlask>());

			if (NPC.downedGolemBoss)
				shop.Add(ModContent.ItemType<CthulhuBlood>());

			if (NPC.downedPlantBoss && Main.bloodMoon)
				shop.Add(ModContent.ItemType<AlchemistGlove>());
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
			projType = ModContent.ProjectileType<BasicFlaskPro>();
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

				for (int i = 0; i < 3; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"AlchemistGore{i + 1}"), 1f);
			}
		}
	}
}