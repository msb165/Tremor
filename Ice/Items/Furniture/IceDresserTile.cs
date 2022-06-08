using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Tremor.Ice.Items.Furniture
{
	public class IceDresserTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileContainer[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			TileObjectData.newTile.Origin = new Point16(1, 1);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16 };
			TileObjectData.newTile.HookCheck = new PlacementHook(Chest.FindEmptyChest, -1, 0, true);
			TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(Chest.AfterPlacement_Hook, -1, 0, false);
			TileObjectData.newTile.AnchorInvalidTiles = new[] { 127 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			AddMapEntry(new Color(87, 144, 165));
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Dressers };
			dresser = "Glacier Wood Dresser";
			dresserDrop = ModContent.ItemType<IceDresser>();
		}

		public override void RightClick(int i, int j)
		{
			Player player = Main.player[Main.myPlayer];
			if (Main.tile[Player.tileTargetX, Player.tileTargetY].frameY == 0)
			{
				Main.CancelClothesWindow(true);
				Main.mouseRightRelease = false;
				int left = Main.tile[Player.tileTargetX, Player.tileTargetY].frameX / 18;
				left %= 3;
				left = Player.tileTargetX - left;
				int top = Player.tileTargetY - Main.tile[Player.tileTargetX, Player.tileTargetY].frameY / 18;
				if (player.sign > -1)
				{
					Main.PlaySound(11, -1, -1, 1);
					player.sign = -1;
					Main.editSign = false;
					Main.npcChatText = string.Empty;
				}
				if (Main.editChest)
				{
					Main.PlaySound(12, -1, -1, 1);
					Main.editChest = false;
					Main.npcChatText = string.Empty;
				}
				if (player.editedChestName)
				{
					player.editedChestName = false;
				}
				if (Main.netMode == 1)
				{
					if (left == player.chestX && top == player.chestY && player.chest != -1)
					{
						player.chest = -1;
						Recipe.FindRecipes();
						Main.PlaySound(11, -1, -1, 1);
					}
					else
					{
						Main.stackSplit = 600;
					}
				}
				else
				{
					player.flyingPigChest = -1;
					int num213 = Chest.FindChest(left, top);
					if (num213 != -1)
					{
						Main.stackSplit = 600;
						if (num213 == player.chest)
						{
							player.chest = -1;
							Recipe.FindRecipes();
							Main.PlaySound(11, -1, -1, 1);
						}
						else if (num213 != player.chest && player.chest == -1)
						{
							player.chest = num213;
							Main.playerInventory = true;
							Main.recBigList = false;
							Main.PlaySound(10, -1, -1, 1);
							player.chestX = left;
							player.chestY = top;
						}
						else
						{
							player.chest = num213;
							Main.playerInventory = true;
							Main.recBigList = false;
							Main.PlaySound(12, -1, -1, 1);
							player.chestX = left;
							player.chestY = top;
						}
						Recipe.FindRecipes();
					}
				}
			}
			else
			{
				Main.playerInventory = false;
				player.chest = -1;
				Recipe.FindRecipes();
				Main.dresserX = Player.tileTargetX;
				Main.dresserY = Player.tileTargetY;
				Main.OpenClothesWindow();
			}
		}

		public override void MouseOverFar(int i, int j)
		{
			Player player = Main.player[Main.myPlayer];
			Tile tile = Main.tile[Player.tileTargetX, Player.tileTargetY];
			int left = Player.tileTargetX;
			int top = Player.tileTargetY;
			left -= tile.frameX % 54 / 18;
			if (tile.frameY % 36 != 0)
			{
				top--;
			}
			int chestIndex = Chest.FindChest(left, top);
			player.showItemIcon2 = -1;
			if (chestIndex < 0)
			{
				player.showItemIconText = "Glacier Wood Dresser";
			}
			else
			{
				if (Main.chest[chestIndex].name != "")
				{
					player.showItemIconText = Main.chest[chestIndex].name;
				}
				else
				{
					player.showItemIconText = chest;
				}
				if (player.showItemIconText == chest)
				{
					player.showItemIcon2 = ModContent.ItemType<IceDresser>();
					player.showItemIconText = "";
				}
			}
			player.noThrow = 2;
			player.showItemIcon = true;
			if (player.showItemIconText == "")
			{
				player.showItemIcon = false;
				player.showItemIcon2 = 0;
			}
		}

		public override void MouseOver(int i, int j)
		{
			Player player = Main.player[Main.myPlayer];
			Tile tile = Main.tile[Player.tileTargetX, Player.tileTargetY];
			int left = Player.tileTargetX;
			int top = Player.tileTargetY;
			left -= tile.frameX % 54 / 18;
			if (tile.frameY % 36 != 0)
			{
				top--;
			}
			int num138 = Chest.FindChest(left, top);
			player.showItemIcon2 = -1;
			if (num138 < 0)
			{
				player.showItemIconText = "Glacier Wood Dresser";
			}
			else
			{
				if (Main.chest[num138].name != "")
				{
					player.showItemIconText = Main.chest[num138].name;
				}
				else
				{
					player.showItemIconText = chest;
				}
				if (player.showItemIconText == chest)
				{
					player.showItemIcon2 = ModContent.ItemType<IceDresser>();
					player.showItemIconText = "";
				}
			}
			player.noThrow = 2;
			player.showItemIcon = true;
			if (Main.tile[Player.tileTargetX, Player.tileTargetY].frameY > 0)
			{
				player.showItemIcon2 = ItemID.FamiliarShirt;
			}
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, dresserDrop);
		}
	}
}