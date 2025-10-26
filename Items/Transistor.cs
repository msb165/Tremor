using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Transistor:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 133;
			Item.DamageType = DamageClass.Melee;
			Item.width = 66;
			Item.height = 66;

			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 13500;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.BrainiacWavePro>();
			Item.shootSpeed = 9f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Transistor");
			/* Tooltip.SetDefault("'Crash() everyone!'\n" +
"Sends energy waves in different directions on swing"); */
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 speed = new Vector2(speedX, speedY);
			speed = speed.RotatedByRandom(MathHelper.ToRadians(60));
			damage = damage;
			speedX = speed.X;
			speedY = speed.Y;
			return true;
		}
	}
}
