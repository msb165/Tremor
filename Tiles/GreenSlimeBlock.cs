using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Tiles
{
	public class GreenSlimeBlock:TremorModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileMergeDirt[Type] = true;
        Main.tileBlockLight[Type] = true;
		HitSound = SoundID.NPCDeath1;
        AddMapEntry(new Color(75, 192, 126));
        //ItemDrop = ModContent.ItemType<GreenSlimeBlock>();
    }
}}