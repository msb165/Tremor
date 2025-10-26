using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Bolter:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 43;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 46;
			Item.height = 32;

			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Arrow;
			Item.shootSpeed = 30f;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 90000;
			Item.rare = 7;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bolter");
			/* Tooltip.SetDefault("Quickly launches arrows\n" +
"Has 50% chance to shoot a Hellfire arrow"); */
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (Main.rand.NextBool(2))
			{
				type = 41;
			}

			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
}
