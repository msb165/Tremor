using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SuperBigCannon:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 340;
			item.DamageType = DamageClass.Ranged;
			item.width = 70;
			item.height = 34;

			item.useTime = 35;
			item.useAnimation = 35;
			item.shoot = ModContent.ProjectileType<Projectiles.SuperBigCannonPro>();
			item.shootSpeed = 15f;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.expert = true;
			item.autoReuse = true;
			item.useAmmo = ModContent.ItemType<SBCCannonballAmmo>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SBC");
			Tooltip.SetDefault("'Seriously big cannon!'");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-18, -4);
		}
	}
}
