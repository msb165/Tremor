using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class VulcanBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 545;
			Item.DamageType = DamageClass.Melee;
			Item.width = 46;
			Item.height = 48;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.shoot = ModContent.ProjectileType<Projectiles.VulcanBladePro>();
			Item.shootSpeed = 12f;
			Item.value = 600000;
			Item.rare = 0;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;
			Item.useTurn = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Vulcan Blade");
			/* Tooltip.SetDefault("Shoots a molten bolt that leaves molten spheres behind\n" +
"Spheres home on enemies, explode on contact and set enemies on fire"); */
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}
	}
}
