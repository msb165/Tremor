using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ThornBall:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 36;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 18;
			Item.height = 18;
			Item.maxStack = 999;
			Item.useTime = 14;
			Item.useAnimation = 14;
			Item.shoot = ModContent.ProjectileType<Projectiles.ThornBall>();
			Item.shootSpeed = 8f;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 155;
			Item.rare = 5;
			Item.consumable = true;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Thorn Ball");
			// Tooltip.SetDefault("");
		}

	}
}
