using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Tremor.NPCs
{
	public class Cybermite:TremorModNPC
	{
		public Vector2 bossCenter
		{
			get { return npc.Center; }
			set { npc.position = value - new Vector2(npc.width / 2, npc.height / 2); }
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cybermite");
		}

		public override void SetDefaults()
		{
			npc.aiStyle = 63;
			npc.lifeMax = 600;
			npc.damage = 70;
			npc.defense = 25;
			npc.knockBackResist = 0f;
			npc.width = 74;
			npc.height = 74;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax = (int)(npc.lifeMax * 0.625f * balance);
			npc.damage = (int)(npc.damage * 0.6f);
		}

		public override void AI()
		{
			Lighting.AddLight(bossCenter, 1f, 0.3f, 0.3f);
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CybermiteGore"), 1f);
		}
	}
}