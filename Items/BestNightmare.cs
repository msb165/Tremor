using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BestNightmare:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 260;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 50;
			Item.shootSpeed = 30f;
			Item.useAnimation = 50;
			Item.useStyle = 1;
			Item.knockBack = 9f;
			Item.shoot = ModContent.ProjectileType<Projectiles.BestNightmarePro>();
			Item.value = 27600;
			Item.rare = 0;
			Item.noUseGraphic = true;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Best Nightmare");
			// Tooltip.SetDefault("");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

	}
}
