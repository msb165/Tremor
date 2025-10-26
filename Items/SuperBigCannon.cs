using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SuperBigCannon:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 340;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 70;
			Item.height = 34;

			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.shoot = ModContent.ProjectileType<Projectiles.SuperBigCannonPro>();
			Item.shootSpeed = 15f;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 100000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item11;
			Item.expert = true;
			Item.autoReuse = true;
			Item.useAmmo = ModContent.ItemType<SBCCannonballAmmo>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SBC");
			// Tooltip.SetDefault("'Seriously big cannon!'");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-18, -4);
		}
	}
}
