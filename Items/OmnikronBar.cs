using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class OmnikronBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 10000;
			Item.rare = 0;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Omnikron Bar");
			// Tooltip.SetDefault("");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(8, 4));
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

	}
}
