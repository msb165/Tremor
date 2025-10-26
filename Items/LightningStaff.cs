using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LightningStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.mana = 22;
			Item.UseSound = SoundID.Item82;
			Item.useStyle = 5;
			Item.damage = 180;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.width = 36;
			Item.height = 40;
			Item.shoot = 580;
			Item.shootSpeed = 13f;

			Item.knockBack = 4.4f;
			Item.staff[Item.type] = true;
			Item.DamageType = DamageClass.Magic;
			Item.autoReuse = true;
			Item.value = 100000;
			Item.rare = 11;
			Item.noMelee = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Lightning Staff");
			// Tooltip.SetDefault("Sends out huge lightnings");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 vector82 = -Main.LocalPlayer.Center + Main.MouseWorld;
			float ai = Main.rand.Next(100);
			Vector2 vector83 = Vector2.Normalize(vector82) * Item.shootSpeed;
			Projectile.NewProjectile(null, player.Center.X, player.Center.Y, vector83.X, vector83.Y, type, damage, .490f, player.whoAmI, vector82.ToRotation(), ai);
			return false;
		}

	}
}
