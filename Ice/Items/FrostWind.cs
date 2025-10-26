using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class FrostWind:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 20;
			Item.DamageType = DamageClass.Melee;
			Item.width = 46;
			Item.height = 46;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 15000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;
			Item.shoot = ModContent.ProjectileType<Projectiles.FrostwindPro>();
			Item.shootSpeed = 12f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frost Wind");
			// Tooltip.SetDefault("");
		}

	}
}
