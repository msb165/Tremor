using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TheGhostClaymore:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 325;
			Item.width = 50;
			Item.height = 50;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 750000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.shoot = ModContent.ProjectileType<Projectiles.TheGhostClaymorePro>();
			Item.shootSpeed = 16f;
			Item.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Ghost Claymore");
			// Tooltip.SetDefault("");
		}

	}
}
