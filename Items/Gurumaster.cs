using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Gurumaster:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 240;
			Item.width = 58;
			Item.height = 30;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 35;
			Item.shoot = ModContent.ProjectileType<Projectiles.Gurumaster>();
			Item.shootSpeed = 15f;
			Item.useAnimation = 35;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 1000000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item36;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gurumaster");
			// Tooltip.SetDefault("");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, -4);
		}
	}
}
