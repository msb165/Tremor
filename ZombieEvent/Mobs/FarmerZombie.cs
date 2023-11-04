using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.ZombieEvent.Mobs
{

	public class FarmerZombie:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Farmer Zombie");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 100;
			npc.damage = 26;
			npc.defense = 24;
			npc.knockBackResist = 0.3f;
			npc.width = 36;
			npc.height = 44;
			AnimationType = 21;
			npc.aiStyle = 3;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 4, 7);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<FarmerZombieBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + npc.width / 2) / 16;
				int centerY = (int)(npc.position.Y + npc.height / 2) / 16;
				int halfLength = npc.width / 2 / 16 + 1;
				//if (Main.rand.NextBool(4))
				//{
				//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Tomato>(), Main.rand.Next(1, 2));
				//};
				//if (Main.rand.NextBool(4))
				//{
				//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Potato>(), Main.rand.Next(1, 2));
				//};
				if(Main.rand.NextBool(6))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Carrot>(), Main.rand.Next(1, 6));
				};
				//if (Main.rand.NextBool(6))
				//{
				//	Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Wheat>(), Main.rand.Next(1, 6));
				//};
			}
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/FarmForkGore"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/FarmGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/FarmGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/FarmGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/FarmGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/FarmGore3"), 1f);
			}
		}

	}
}