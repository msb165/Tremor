using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class CorruptorGun:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 26;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 42;
			Item.height = 30;

			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4f;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.rare = 3;
			Item.UseSound = SoundID.Item40;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.shootSpeed = 15f;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Corruptor Gun");
			// Tooltip.SetDefault("Spends bullets and fires small corruptors");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 307;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override Vector2? HoldoutOffset()
		{
			return Vector2.Zero;
		}
	}
}
