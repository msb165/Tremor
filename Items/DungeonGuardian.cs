using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DungeonGuardian:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dungeon Guardian");
			// Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(3279);
			Item.width = 30;
			Item.height = 26;
			Item.shoot = ModContent.ProjectileType<Projectiles.DungeonGuardianPro>();
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 2;
			if (!NPC.downedBoss1)
			{
				Item.damage = 15;
			}
			if (NPC.downedBoss1)
			{
				Item.damage = 25;
			}
			if (NPC.downedBoss2)
			{
				Item.damage = 30;
			}
			if (NPC.downedBoss3)
			{
				Item.damage = 35;
			}
			if (Main.hardMode)
			{
				Item.damage = 50;
			}
			if (NPC.downedMechBossAny)
			{
				Item.damage = 75;
			}
			if (NPC.downedPlantBoss)
			{
				Item.damage = 100;
			}
			if (NPC.downedGolemBoss)
			{
				Item.damage = 125;
			}
			if (NPC.downedMoonlord)
			{
				Item.damage = 175;
			}
		}
	}
}
