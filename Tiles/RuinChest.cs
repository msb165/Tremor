using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Tremor.Items;
using Tremor.NPCs;

namespace Tremor.Tiles
{
	public class RuinChest:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSpelunker[Type] = true;
			Main.tileContainer[Type] = true;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 1200;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			//Main.tileValue[Type] = 500;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.Origin = new Point16(0, 1);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
			TileObjectData.newTile.HookCheckIfCanPlace = new PlacementHook(Chest.FindEmptyChest, -1, 0, true);
			TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(Chest.AfterPlacement_Hook, -1, 0, false);
			TileObjectData.newTile.AnchorInvalidTiles = new[] { 127 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
			TileObjectData.addTile(Type);
			AddMapEntry(new Color(91, 78, 67));
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Containers };
			chest = "Ruin Chest";
			TileID.Sets.BasicChest[Type] = true;
		}

		public string MapChestName(string name, int i, int j)
		{
			int left = i;
			int top = j;
			Tile tile = Main.tile[i, j];
			if (tile.TileFrameX % 36 != 0)
			{
				left--;
			}
			if (tile.TileFrameY != 0)
			{
				top--;
			}
			int chest = Chest.FindChest(left, top);
			if (Main.chest[chest].name == "")
			{
				return name;
			}
			return name + ": " + Main.chest[chest].name;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = 1;
		}

		public override bool CanKillTile(int i, int j, ref bool blockDamaged)
		{
			Tile tile = Main.tile[i, j];
			int left = i;
			int top = j;
			if (tile.TileFrameX % 36 != 0)
			{
				left--;
			}
			if (tile.TileFrameY != 0)
			{
				top--;
			}
			return Chest.CanDestroyChest(left, top);
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(null, i * 16, j * 16, 32, 32, ModContent.ItemType<Items.RuinChest>());
			Chest.DestroyChest(i, j);
		}

		const int XOffset = 400;
		const int YOffset = 400;
		public override bool RightClick(int i, int j)
		{
			Player player = Main.player[Main.myPlayer];
			if (player.cursorItemIconID == ModContent.ItemType<RuinKey>())
			{
				for (int num66 = 0; num66 < 58; num66++)
				{
					if (player.inventory[num66].type == ModContent.ItemType<RuinKey>() && player.inventory[num66].stack > 0)
					{
						NPC.NewNPC(null, (int)player.Center.X + XOffset, (int)player.Center.Y + YOffset, ModContent.NPCType<RuinGhost1>());
						NPC.NewNPC(null, (int)player.Center.X + XOffset, (int)player.Center.Y - YOffset, ModContent.NPCType<RuinGhost1>());
						NPC.NewNPC(null, (int)player.Center.X - XOffset, (int)player.Center.Y + YOffset, ModContent.NPCType<RuinGhost1>());
						NPC.NewNPC(null, (int)player.Center.X - XOffset, (int)player.Center.Y - YOffset, ModContent.NPCType<RuinGhost1>());
						player.inventory[num66].stack--;
						Chest.Unlock(i, j);
						Chest.Unlock(i - 1, j - 1);
						Chest.Unlock(i, j - 1);
						Chest.Unlock(i - 1, j);
					}
				}
			}
			Tile tile = Main.tile[i, j];
			if (tile.TileFrameX != 72 && tile.TileFrameX != 90)
			{
				Main.mouseRightRelease = false;
				int left = i;
				int top = j;
				if (tile.TileFrameX % 36 != 0)
				{
					left--;
				}
				if (tile.TileFrameY != 0)
				{
					top--;
				}
				if (player.sign >= 0)
				{
					Terraria.Audio.SoundEngine.PlaySound(SoundID.MenuClose);
					player.sign = -1;
					Main.editSign = false;
					Main.npcChatText = "";
				}
				if (Main.editChest)
				{
					Terraria.Audio.SoundEngine.PlaySound(SoundID.MenuTick);
					Main.editChest = false;
					Main.npcChatText = "";
				}
				if (player.editedChestName)
				{
					//NetMessage.SendData(33, -1, -1, NetworkText.FromLiteral(Main.chest[player.chest].name), player.chest, 1f, 0f, 0f, 0, 0, 0);
					player.editedChestName = false;
				}
				if (Main.netMode == 1)
				{
					if (left == player.chestX && top == player.chestY && player.chest >= 0)
					{
						player.chest = -1;
						Recipe.FindRecipes();
						Terraria.Audio.SoundEngine.PlaySound(SoundID.MenuClose);
					}
					else
					{
						NetMessage.SendData(31, -1, -1, null, left, top, 0f, 0f, 0, 0, 0);
						Main.stackSplit = 600;
					}
				}
				else
				{
					int chest = Chest.FindChest(left, top);
					if (chest >= 0)
					{
						Main.stackSplit = 600;
						if (chest == player.chest)
						{
							player.chest = -1;
							Terraria.Audio.SoundEngine.PlaySound(SoundID.MenuClose);
						}
						else
						{
							player.chest = chest;
							Main.playerInventory = true;
							Main.recBigList = false;
							player.chestX = left;
							player.chestY = top;
							SoundEngine.PlaySound(player.chest < 0 ? SoundID.MenuOpen : SoundID.MenuTick);
						}
						Recipe.FindRecipes();
					}
				}
			}
			return true;
		}

		public override void MouseOver(int i, int j)
		{
			Player player = Main.player[Main.myPlayer];
			Tile tile = Main.tile[i, j];
			int left = i;
			int top = j;
			if (tile.TileFrameX % 36 != 0)
			{
				left--;
			}
			if (tile.TileFrameY != 0)
			{
				top--;
			}
			int chest = Chest.FindChest(left, top);
			player.cursorItemIconID = -1;
			if (chest < 0)
			{
				player.cursorItemIconText = Lang.chestType[0].Value;
			}
			else
			{
				player.cursorItemIconText = Main.chest[chest].name.Length > 0 ? Main.chest[chest].name : "Ruin Chest";
				if (player.cursorItemIconText == "Ruin Chest")
				{
					if (tile.TileFrameX == 72 || tile.TileFrameX == 90)
					{
						player.cursorItemIconID = ModContent.ItemType<RuinKey>();
						player.cursorItemIconText = "";
					}
					else
					{
						player.cursorItemIconID = ModContent.ItemType<Items.RuinChest>();
					}
				}
			}
			player.noThrow = 2;
			player.cursorItemIconEnabled = true;
		}

		public override void MouseOverFar(int i, int j)
		{
			MouseOver(i, j);
			Player player = Main.player[Main.myPlayer];
			if (player.cursorItemIconText == "")
			{
				player.cursorItemIconEnabled = false;
				player.cursorItemIconID = 0;
			}
		}
	}
}