using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ThrowingAxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 15;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.ThrowingAxe>();
			Item.shootSpeed = 10f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 14;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Throwing Axe");
			// Tooltip.SetDefault("");
		}

	}
}
