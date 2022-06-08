using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Walls
{
	public class GloomstoneBrickWall : ModWall
{
    public override void SetDefaults()
    {
        Main.wallHouse[Type] = true;
        drop = ModContent.ItemType<Items.GloomstoneBrickWall>();
	AddMapEntry(new Color(10, 63, 98));
    }
}}