using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	//ported from my tAPI mod because I don't want to make more artwork
	public class BlackRose:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.DamageType = DamageClass.Magic;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 7;
			Item.useAnimation = 28;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 5, 0, 0);
			Item.rare = 3;
			Item.mana = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.BlackRosePro>();
			Item.shootSpeed = 30f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Black Rose");
			// Tooltip.SetDefault("");
		}

	}
}
