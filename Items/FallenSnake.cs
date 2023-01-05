using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class FallenSnake:TremorModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ValkyrieYoyo);

			item.damage = 180;
			item.width = 30;
			item.height = 26;

			item.shootSpeed = 25f;
			item.shoot = ModContent.ProjectileType<Projectiles.FallenSnakePro>();
			item.knockBack = 5;
			item.value = 1000000;
			item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Fallen Snake");
			Tooltip.SetDefault("Killed enemies drop more money");
		}

	}
}
