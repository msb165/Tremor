using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NecromancerClaymore:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.shoot = ModContent.ProjectileType<Projectiles.BoneSpike>();
			Item.shootSpeed = 6f;
			Item.knockBack = 4;
			Item.value = 66600;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Necromancer Claymore");
			// Tooltip.SetDefault("");
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 26);
		}
	}
}
