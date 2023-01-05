using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TheGhostClaymore:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 325;
			item.width = 50;
			item.height = 50;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 750000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = ModContent.ProjectileType<Projectiles.TheGhostClaymorePro>();
			item.shootSpeed = 16f;
			item.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Ghost Claymore");
			Tooltip.SetDefault("");
		}

	}
}
