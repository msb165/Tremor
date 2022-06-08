using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Walls
{
	public class NightmareBrickWall : ModWall
{
    public override void SetDefaults()
    {
        Main.wallHouse[Type] = true;
        drop = ModContent.ItemType<Items.NightmareBrickWall>();
	AddMapEntry(new Color(90, 12, 157));
    }
}}