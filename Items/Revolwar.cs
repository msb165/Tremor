using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Revolwar:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.useStyle = 5;
			Item.useAnimation = 16;
			Item.useTime = 16;

			Item.width = 24;
			Item.height = 28;
			Item.shoot = 14;
			Item.useAmmo = AmmoID.Bullet;
			Item.UseSound = SoundID.Item11;
			Item.damage = 450;
			Item.shootSpeed = 12f;
			Item.noMelee = true;
			Item.value = 500000;
			Item.scale = 0.9f;
			Item.rare = 0;
			Item.DamageType = DamageClass.Ranged;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Revolwar");
			// Tooltip.SetDefault("");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, -2);
		}
	}
}
