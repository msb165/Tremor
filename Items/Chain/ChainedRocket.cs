using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Chain
{
	public class ChainedRocket:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;
			item.rare = 11;
			item.noMelee = true;
			item.useStyle = 5;
			item.useAnimation = 30;
			item.useTime = 30;
			item.value = 2100000;
			item.knockBack = 7.5F;
			item.damage = 262;
			item.autoReuse = true;
			item.scale = 1.1F;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<Projectiles.ChainedRocketPro>();
			item.shootSpeed = 22.9F;
			item.UseSound = SoundID.Item1;
			item.DamageType = DamageClass.Melee;
			item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chained Rocket");
			Tooltip.SetDefault("");
		}

	}
}
