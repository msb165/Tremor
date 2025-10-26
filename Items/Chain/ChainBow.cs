using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Chain
{
	public class ChainBow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 300;
			Item.width = 16;
			Item.height = 32;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 20;
			Item.shoot = 1;

			Item.shootSpeed = 60f;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 1250000;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 11;
			Item.crit = 7;
			Item.UseSound = SoundID.Item114;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chain Bow");
			// Tooltip.SetDefault("Shoots cosmic rays!");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 255;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
}
