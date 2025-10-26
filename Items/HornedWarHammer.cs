using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HornedWarHammer:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Arkhalis);

			Item.damage = 350;
			Item.knockBack = 4;
			Item.rare = 11;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Horned War Hammer");
			// Tooltip.SetDefault("Forged from lightning");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<Projectiles.HornedWarhammerPro>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

	}
}
