using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GehennaStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 455;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 15;
			Item.width = 46;
			Item.height = 48;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.shoot = ModContent.ProjectileType<Projectiles.InfernoRift>();
			Item.shootSpeed = 12f;
			Item.value = 600000;
			Item.rare = 0;
			Item.UseSound = SoundID.Item44;
			Item.autoReuse = false;
			Item.useTurn = false;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gehenna Staff");
			// Tooltip.SetDefault("Summons a controllable inferno rift that rapidly shoots molten bolts at nearby enemies");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			player.channel = true;
			return true;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}
	}
}
