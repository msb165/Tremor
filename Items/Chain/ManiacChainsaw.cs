using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Chain
{

	public class ManiacChainsaw:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 202;
			Item.DamageType = DamageClass.Melee;
			Item.width = 140;
			Item.height = 34;
			Item.useTime = 8;
			Item.useAnimation = 25;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.axe = 35;
			Item.tileBoost += 5;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 1, 50, 0);
			Item.rare = 10;
			Item.UseSound = SoundID.Item23;
			Item.autoReuse = true;

			Item.shoot = ModContent.ProjectileType<Projectiles.ManiacChainsawPro>();
			Item.shootSpeed = 0.4f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Maniacal Chainsaw");
			// Tooltip.SetDefault("'A weapon of a true man killer'");
		}

	}
}
