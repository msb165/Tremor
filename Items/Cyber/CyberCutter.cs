using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Cyber
{
	public class CyberCutter:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 76;
			Item.DamageType = DamageClass.Magic;
			Item.width = 38;
			Item.height = 38;
			Item.scale = 1.1f;
			Item.maxStack = 1;

			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.knockBack = 4f;
			Item.UseSound = SoundID.Item23;
			Item.noMelee = true;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.useTurn = true;
			Item.useStyle = 5;
			Item.value = 10000;
			Item.rare = 5;
			Item.shoot = ModContent.ProjectileType<Projectiles.CyberCutterPro>();
			Item.shootSpeed = 5f;
			Item.mana = 14;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cyber Cutter");
			// Tooltip.SetDefault("Casts a controllable saw");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			player.channel = true;
			return true;
		}
	}
}
