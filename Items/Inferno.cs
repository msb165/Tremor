using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Inferno:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 520;
			Item.width = 62;
			Item.height = 62;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.InfernoPro>();
			Item.shootSpeed = 12f;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 600000;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Inferno");
			// Tooltip.SetDefault("");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}
	}
}
