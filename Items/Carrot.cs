using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Carrot:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 15;
			item.DamageType = DamageClass.Ranged;
			item.width = 22;
			item.height = 22;
			item.maxStack = 999;

			item.consumable = true;
			item.knockBack = 1.5f;
			item.rare = 0;
			item.shoot = ModContent.ProjectileType<Projectiles.Carrot>();
			item.ammo = item.type;
			item.value = 15;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Carrot");
			Tooltip.SetDefault("");
		}

	}
}
