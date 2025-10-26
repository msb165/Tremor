using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Alchemist;

namespace Tremor
{
	public class NPCDrops : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			switch (npc.type)
			{
				case NPCID.WallofFlesh:
					npcLoot.Add(ItemDropRule.Common(ItemID.FlaskofIchor, 7));
					npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AlchemistEmblem>(), 5));
					npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ThrowerEmblem>(), 5));
					break;
			}
		}
	}

	public class BossBags : GlobalItem
	{
		public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
		{
			switch (item.type)
			{
				case ItemID.WallOfFleshBossBag:
					itemLoot.Add(ItemDropRule.Common(ItemID.FlaskofIchor, 7));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AlchemistEmblem>(), 5));
					itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ThrowerEmblem>(), 5));
					break;
			}
		}
	}
}

