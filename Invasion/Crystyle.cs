using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class Crystyle:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 266;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 52;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.shoot = 173;
			Item.shootSpeed = 7f;
			Item.knockBack = 4;
			Item.value = 100000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crystyle");
			// Tooltip.SetDefault("");
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 59);
		}

	}
}
