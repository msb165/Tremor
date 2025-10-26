using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Dark;

namespace Tremor.NPCs
{

	public class DarkSlime:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dark Slime");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 600;
			npc.damage = 125;
			npc.defense = 40;
			npc.knockBackResist = 0.3f;
			npc.width = 30;
			npc.height = 23;
			AnimationType = 244;
			npc.aiStyle = 41;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 0);
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 191, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);

				Dust.NewDust(npc.position, npc.width, npc.height, 191, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 191, 2.5f * hit.HitDirection, -2.5f, 0, Color.Green, 0.7f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 99, 1f);
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(8))
				npc.NewItem(ModContent.ItemType<DarkGel>(), Main.rand.Next(1, 3));
		}
	}
}