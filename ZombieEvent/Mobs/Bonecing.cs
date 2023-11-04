using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Mobs
{

	public class Bonecing:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bonecing");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 160;
			npc.damage = 80;
			npc.defense = 20;
			npc.knockBackResist = 0.5f;
			npc.width = 58;
			npc.height = 44;
			AnimationType = 177;
			AIType = 177;
			npc.aiStyle = 41;
			npc.npcSlots = 0.2f;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 9, 9);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<BigCorpseBanner>();
		}

		public override void AI()
		{
			if (NPC.AnyNPCs(ModContent.NPCType<Cryptomage>()))
			{
				npc.Transform(ModContent.NPCType<SuperBonecing>());
			}
		}
	}
}