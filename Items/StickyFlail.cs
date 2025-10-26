using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StickyFlail:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 10;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.rare = 3;
			Item.noMelee = true;
			Item.useStyle = 5;
			Item.useAnimation = 40;
			Item.useTime = 40;
			Item.knockBack = 7.5F;
			Item.damage = 22;
			Item.scale = 1.1F;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.StickyFlailPro>();
			Item.shootSpeed = 15.9F;
			Item.UseSound = SoundID.Item1;
			Item.DamageType = DamageClass.Melee;
			Item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sticky Flail");
			// Tooltip.SetDefault("");
		}

	}
}
