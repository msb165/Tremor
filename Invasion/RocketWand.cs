using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class RocketWand:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Starfury);

			Item.damage = 300;
			//Item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 20;
			Item.mana = 9;

			Item.useAnimation = 50;
			Item.useStyle = 5;
			Item.shootSpeed = 10f;
			Item.staff[Item.type] = true;
			Item.knockBack = 3;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item9;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rocket Wand");
			// Tooltip.SetDefault("Causes missiles to fall from the sky");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 134;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

	}
}
