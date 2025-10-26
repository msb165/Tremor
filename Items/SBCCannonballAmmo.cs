using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SBCCannonballAmmo:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 340;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 22;
			Item.height = 22;
			Item.maxStack = 999;

			Item.consumable = true;
			Item.knockBack = 1.5f;
			Item.value = 1000;
			Item.rare = 11;
			Item.shoot = ModContent.ProjectileType<Projectiles.SuperBigCannonPro>();
			Item.ammo = Item.type;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SBC Cannonball");
			// Tooltip.SetDefault("");
		}

	}
}
