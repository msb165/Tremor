using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrebleClef:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.mana = 6;
			Item.noMelee = true;
			Item.useStyle = 5;
			Item.damage = 362;
			Item.autoReuse = true;
			Item.useAnimation = 12;
			Item.useTime = 12;
			Item.width = 40;
			Item.height = 40;
			Item.shoot = 76;
			Item.shootSpeed = 6f;
			Item.knockBack = 6f;
			Item.value = Item.sellPrice(0, 40, 0, 0);
			Item.DamageType = DamageClass.Magic;
			Item.noMelee = true;
			Item.rare = 0;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Treble Clef");
			// Tooltip.SetDefault("");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-28, -9);
		}
	}
}
