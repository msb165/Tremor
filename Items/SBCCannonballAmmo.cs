using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SBCCannonballAmmo:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 340;
			item.DamageType = DamageClass.Ranged;
			item.width = 22;
			item.height = 22;
			item.maxStack = 999;

			item.consumable = true;
			item.knockBack = 1.5f;
			item.value = 1000;
			item.rare = 11;
			item.shoot = ModContent.ProjectileType<Projectiles.SuperBigCannonPro>();
			item.ammo = item.type;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SBC Cannonball");
			Tooltip.SetDefault("");
		}

	}
}
