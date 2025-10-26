using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TheTide:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 44;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 52;
			Item.height = 22;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 6;
			Item.value = 50000;

			Item.rare = 5;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 27;
			Item.shootSpeed = 26f;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Tide");
			/* Tooltip.SetDefault("Shoots fast moving water bolts\n" +
"Uses bullets as ammo"); */
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 27;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-16, 0);
		}
	}
}
