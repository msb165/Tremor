using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class FallenSnake:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ValkyrieYoyo);

			Item.damage = 180;
			Item.width = 30;
			Item.height = 26;

			Item.shootSpeed = 25f;
			Item.shoot = ModContent.ProjectileType<Projectiles.FallenSnakePro>();
			Item.knockBack = 5;
			Item.value = 1000000;
			Item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Fallen Snake");
			// Tooltip.SetDefault("Killed enemies drop more money");
		}

	}
}
