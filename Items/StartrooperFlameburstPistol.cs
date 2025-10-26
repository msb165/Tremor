using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StartrooperFlameburstPistol:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 248;
			Item.width = 30;
			Item.height = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 30;
			Item.shoot = 666;

			Item.shootSpeed = 20f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 450000;
			Item.useAmmo = AmmoID.Bullet;
			Item.rare = 11;
			Item.crit = 7;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Startrooper Flameburst Pistol");
			// Tooltip.SetDefault("Uses bullets as ammo");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 666;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 2);
		}
	}
}
