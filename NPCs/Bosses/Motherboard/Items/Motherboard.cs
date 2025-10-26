using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.Motherboard.Items
{
	public class Motherboard:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 38;
			Item.maxStack = 20;

			Item.rare = 9;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.UseSound = SoundID.Item44;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Motherboard");
			// Tooltip.SetDefault("You shouldn't have this");
		}

		public override bool? UseItem(Player player)
		{
			Main.dayTime = false;
			//summonWallOfShadows(player);
			//NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<CogLord>());
			return true;
		}

		public void summonWallOfShadows(Player player)
		{
			Vector2 spawnPos;
			int dir;
			if (player.Center.X > Main.rightWorld / 2)
			{
				spawnPos = new Vector2(player.Center.X + Main.screenWidth / 2 + 25, player.Center.Y + 1050);
				dir = -1;
			}
			else
			{
				spawnPos = new Vector2(player.Center.X - Main.screenWidth / 2 - 25, player.Center.Y + 1050);
				dir = 1;
			}
			int newWall = NPC.NewNPC(null, (int)spawnPos.X, (int)spawnPos.Y, ModContent.NPCType<WallOfShadow>(), 0, dir, 0, 0, 0, player.whoAmI);
		}
	}
}
