using Microsoft.Xna.Framework.Graphics;
using System.Linq;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Tremor.Items;
using Tremor.Items.Archer;
using System.Collections.Generic;

namespace Tremor.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Archer:TremorModNPC
	{
		public override string Texture => $"{typeof(Archer).NamespaceToPath()}/Archer";

		//public override string[] AltTextures => new[] { $"{typeof(Archer).NamespaceToPath()}/Archer" };

		//public override bool Autoload(ref string name)
		//{
		//	name = "Archer";
		//	return mod.Properties.Autoload;
		//}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Archer");
			Main.npcFrameCount[npc.type] = 26;
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

			npc.width = 30;
			npc.height = 48;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.knockBackResist = 0.5f;

			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			AnimationType = NPCID.Guide;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs)/* tModPorter Suggestion: Copy the implementation of NPC.SpawnAllowed_Merchant in vanilla if you to count money, and be sure to set a flag when unlocked, so you don't count every tick. */
			=> Main.player.Any(player => !player.dead);

		private readonly List<string> _names = new List<string>
		{
			"Richard",
			"Arthur:2",
			"Jack",
			"William:2",
			"Robin",
			"Wales"
		};

		public override List<string> SetNPCNameList() => _names;

		private readonly WeightedRandom<string> _chats = new WeightedRandom<string>(
			"You'd have to be a very good archer in order to shoot an arrow into a knee.".ToWeightedTuple(2),
			"I'd like to get my hands on a goblintech bow. Those things can shoot multiple arrows.".ToWeightedTuple(.5),
			"I deal in long distance death! Have a look at my wares.".ToWeightedTuple(),
			"I will shoot you with my best arrow if you will not buy anything!".ToWeightedTuple(),
			"Guns? Guns are for cowards!".ToWeightedTuple(),
			"You don't need to make arrows. You need to buy them!".ToWeightedTuple()
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

		public override void ModifyActiveShop(string shopName, Item[] items)
		{
			NPCShop shop = new(Type);
			shop.Add(ItemID.WoodenArrow);
			shop.Add(ModContent.ItemType<ArcherGlove>());
			shop.Add(ModContent.ItemType<Crossbow>());

			if (NPC.downedBoss1)
			{
				shop.Add(ModContent.ItemType<Quiver>());
				shop.Add(ModContent.ItemType<MiniGun>());
				shop.Add(ItemID.JestersArrow);
				shop.Add(ModContent.ItemType<LeatherHat>());
				shop.Add(ModContent.ItemType<LeatherShirt>());
				shop.Add(ModContent.ItemType<LeatherGreaves>());
			}

			if (NPC.downedBoss2)
			{
				shop.Add(ItemID.UnholyArrow);
				shop.Add(ModContent.ItemType<DragonGem>());
			}

			if (Main.hardMode)
			{
				shop.Add(ItemID.HolyArrow);
				shop.Add(ItemID.HellfireArrow);
			}
			
			if (Main.bloodMoon)
				shop.Add(ItemID.BoneArrow);
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

		public override void DrawTownAttackGun(ref Texture2D item, ref Rectangle itemFrame, ref float scale, ref int horizontalHoldoutOffset)/* tModPorter Note: closeness is now horizontalHoldoutOffset, use 'horizontalHoldoutOffset = Main.DrawPlayerItemPos(1f, itemtype) - originalClosenessValue' to adjust to the change. See docs for how to use hook with an item type. */ //Allows you to customize how this town NPC's weapon is drawn when this NPC is shooting (this NPC must have an attack type of 1). Scale is a multiplier for the item's drawing size, item is the ID of the item to be drawn, and closeness is how close the item should be drawn to the NPC.
		{
			scale = 1f;
			Main.GetItemDrawFrame(!Main.hardMode ? ItemID.DemonBow : ItemID.ShadowFlameBow, out Texture2D itemTexture, out Rectangle itemFrame1);
			item = itemTexture;
			horizontalHoldoutOffset = 20;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
		{
			projType = !Main.hardMode ? ProjectileID.FireArrow : ProjectileID.ShadowFlameArrow;
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

				for(int i = 0; i < 3; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"ArcherGore{i+1}"), 1f);
			}
		}
	}
}