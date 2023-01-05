using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI.Chat;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.UI.Chat;

namespace Tremor.NPCs.Bosses.NovaPillar
{
	public class NovaHandler : ModSystem
	{
		public static int TowerX = -1;
		public static int TowerY = -1;
		public static bool TowerActive;
		public static int ShieldStrength;

		public static bool LunarApocalypseLastTick;

		public override void OnWorldLoad()
		{
			LunarApocalypseLastTick = NPC.LunarApocalypseIsUp;
			ShieldStrength = NPC.ShieldStrengthTowerMax;
			TowerX = -1;
			TowerY = -1;
		}

		public override void PreUpdateWorld()
		{
			TowerActive = NPC.AnyNPCs(ModContent.NPCType<NovaPillar>());
		}

		public override void SaveWorldData(TagCompound tag)
		{
			tag.Add("NovaActive", TowerActive);
			if (TowerX != -1)
			{
				tag.Add("NovaX", TowerX);
				tag.Add("NovaY", TowerY);
			}
		}

		public override void LoadWorldData(TagCompound tag)
		{
			TowerActive = tag.GetBool("NovaActive");
			if (tag.ContainsKey("NovaX"))
			{
				TowerX = tag.GetInt("NovaX");
				TowerY = tag.GetInt("NovaY");
				NPC.NewNPC(null, TowerX, TowerY, ModContent.NPCType<NovaPillar>());
			}
		}

		public override void PostUpdateWorld()
		{
			if (NPC.LunarApocalypseIsUp && !LunarApocalypseLastTick)
			{
				Tremor.Log("Moving pillars...");
				var towers = new int[5];

				foreach (var npc in Main.npc)
				{
					if (npc == null) continue;
					if (npc.type == NPCID.LunarTowerNebula) towers[0] = npc.whoAmI;
					if (npc.type == NPCID.LunarTowerSolar) towers[1] = npc.whoAmI;
					if (npc.type == NPCID.LunarTowerStardust) towers[2] = npc.whoAmI;
					if (npc.type == NPCID.LunarTowerVortex) towers[3] = npc.whoAmI;
				}
				towers[4] = -1;
				towers = towers.OrderBy(x => Main.rand.Next()).ToArray();

				for (int i = 0; i < 5; i++)
				{
					MovePillar(i, towers[i]);
				}
			}
			else if (!NPC.LunarApocalypseIsUp && LunarApocalypseLastTick && TowerActive)
			{
				const string newText = "Your hands are shaking...";
				var newColor = new Color(175, 75, 255);
				//TODO: Chat manipulation
				if(Main.chatMonitor is RemadeChatMonitor chatMonitor)
				{
					var chatLine = (List<ChatMessageContainer>)typeof(RemadeChatMonitor).GetField("_messages", System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance).GetValue(chatMonitor);
					for (int i = chatLine.Count - 1; i >= 0; i--)
					{
						if (chatLine[i].OriginalText.StartsWith("Impending doom"))
						{
							chatLine[i].SetContents(newText, newColor, -1);
							break;
						}
					}
				}
				else
				{
					Main.NewText(newText, newColor);
				}
				NPC.MoonLordCountdown = 0;
			}

			LunarApocalypseLastTick = NPC.LunarApocalypseIsUp;
		}

		void MovePillar(int position, int whoAmI)
		{
			if (whoAmI == -1)
			{
				Tremor.Log("Spawning Nova Pillar");
			}
			//else
			//{
			//Tremor.Log("Moving " + Main.npc[whoAmI].displayName);
			// }

			int x = Main.maxTilesX / 6 * (1 + position);
			var spawnPos = new Vector2(x * 16, (float)(Main.worldSurface - 40) * 16);

			bool success = false;
			for (int attempts = 0; attempts < 30; attempts++)
			{
				int offsetX = Main.rand.Next(-100, 101);
				for (int y = (int)Main.worldSurface; y > 100; y--)
				{
					if (!Collision.SolidTiles(x + offsetX - 10, x + offsetX + 10, y - 20, y + 15) && !WorldGen.PlayerLOS(x + offsetX - 10, y) && !WorldGen.PlayerLOS(x + offsetX + 10, y) && !WorldGen.PlayerLOS(x + offsetX - 10, y - 20) && !WorldGen.PlayerLOS(x + offsetX + 10, y - 20))
					{
						spawnPos = new Vector2((x + offsetX) * 16, y * 16);
						success = true;
						break;
					}
				}
				if (success)
				{
					break;
				}
			}

			if (whoAmI == -1)
			{
				whoAmI = NPC.NewNPC(null, (int)spawnPos.X, (int)spawnPos.Y, ModContent.NPCType<NovaPillar>());
				TowerX = (int)spawnPos.X;
				TowerY = (int)spawnPos.Y;
			}
			else
			{
				Main.npc[whoAmI].Center = spawnPos;
				ShieldStrength = NPC.ShieldStrengthTowerMax;
				TowerActive = true;
			}
			if (Main.netMode == 2 && whoAmI < 200)
			{
				NetMessage.SendData(MessageID.SyncNPC, number: whoAmI);
			}
		}

		static readonly string[] NovaNPCs =
		{
			"NovaAlchemist",
			"Varki",
			"Youwarkee",
			"Deadling",
			"NovaFlier"
		};

		public class AuroraGlobalNPC : GlobalNPC
		{
			public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
			{
				if (player.GetModPlayer<TremorPlayer>().ZoneTowerNova)
				{
					spawnRate = (int)(spawnRate * 0.14f);
					maxSpawns = (int)(maxSpawns * 5f);
				}
			}
		}
	}
}
