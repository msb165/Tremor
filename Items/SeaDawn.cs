using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SeaDawn:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 225;
			item.DamageType = DamageClass.Melee;
			item.width = 72;
			item.height = 72;
			item.useTime = 38;
			item.useAnimation = 38;
			item.useStyle = 1;
			item.shootSpeed = 12f;
			item.shoot = ModContent.ProjectileType<Projectiles.TyphoonPro>();
			item.knockBack = 3;
			item.value = 33000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sea Dawn");
			Tooltip.SetDefault("");
		}

	}
}
