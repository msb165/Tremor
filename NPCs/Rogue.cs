using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class Rogue:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rogue");
			Main.npcFrameCount[npc.type] = 12;
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 16;
			npc.defense = 10;
			npc.lifeMax = 86;
			npc.HitSound = SoundID.NPCHit40;
			npc.DeathSound = SoundID.NPCDeath42;
			npc.value = Item.buyPrice(0, 0, 4, 7);
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			AIType = 111;
			AnimationType = 379;
			Banner = npc.type;
			BannerItem = ModContent.ItemType<RogueBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(2))
				this.NewItem(ItemID.WoodenArrow, Main.rand.Next(2, 6));
			if (Main.rand.NextBool(4))
				this.NewItem(ItemID.FlamingArrow, Main.rand.Next(2, 6));

			if (Main.rand.Next(15) == 0)
				this.NewItem(ItemID.Sapphire, Main.rand.Next(1, 3));
			if (Main.rand.Next(15) == 0)
				this.NewItem(ItemID.Ruby, Main.rand.Next(1, 3));
			if (Main.rand.Next(15) == 0)
				this.NewItem(ItemID.Emerald, Main.rand.Next(1, 3));
			if (Main.rand.Next(15) == 0)
				this.NewItem(ItemID.Topaz, Main.rand.Next(1, 3));
			if (Main.rand.Next(15) == 0)
				this.NewItem(ItemID.Amethyst, Main.rand.Next(1, 3));
			if (Main.rand.Next(15) == 0)
				this.NewItem(ItemID.Diamond, Main.rand.Next(1, 3));

			if (Main.rand.NextBool(3))
				this.NewItem(ItemID.ThrowingKnife, Main.rand.Next(2, 6));
			if (Main.rand.NextBool(5))
				this.NewItem(ItemID.PoisonedKnife, Main.rand.Next(2, 4));
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				for(int i = 0; i < 3; ++i)
					Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot($"Gores/RogueGore{i+1}"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> spawnInfo.SpawnTileY < Main.rockLayer && !Main.dayTime ? 0.01f : 0f;
	}
}
