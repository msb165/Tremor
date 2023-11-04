using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Waters
{
	public class IceWater : ModWaterStyle
	{
		//TODO: [Skipped for 1.4] Use WaterStyle
        public /*override*/ bool ChooseWaterStyle()
        {
            TremorPlayer modPlayer = Main.LocalPlayer.GetModPlayer<TremorPlayer>();
            return modPlayer.ZoneIce;
        }

        public override int ChooseWaterfallStyle()
		{
			return Slot;//Mod.GetWaterfallStyleSlot<IceWaterfall>();
		}

		public override int GetSplashDust()
		{
			return ModContent.DustType<Dusts.IceWaterSplash>();
		}

		public override int GetDropletGore()
		{
			return Mod.GetGoreSlot("Gores/IceDroplet");
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.White;
		}
	}
}