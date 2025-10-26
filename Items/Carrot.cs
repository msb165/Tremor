using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Carrot:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 15;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 22;
			Item.height = 22;
			Item.maxStack = 999;

			Item.consumable = true;
			Item.knockBack = 1.5f;
			Item.rare = 0;
			Item.shoot = ModContent.ProjectileType<Projectiles.Carrot>();
			Item.ammo = Item.type;
			Item.value = 15;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Carrot");
			// Tooltip.SetDefault("");
		}

	}
}
