using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class DeadBranch:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.width = 40;
			Item.height = 20;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 5;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 7;
			Item.noMelee = true;

			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.shootSpeed = 20f;
			Item.staff[Item.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dead Branch");
			// Tooltip.SetDefault("Shoots shadow bolts");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int proj = Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, 671, damage, knockBack, Main.myPlayer);
			Main.projectile[proj].hostile = false;
			Main.projectile[proj].friendly = true;
			return false;
		}
	}
}
