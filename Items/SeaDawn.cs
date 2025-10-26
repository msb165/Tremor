using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SeaDawn:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 225;
			Item.DamageType = DamageClass.Melee;
			Item.width = 72;
			Item.height = 72;
			Item.useTime = 38;
			Item.useAnimation = 38;
			Item.useStyle = 1;
			Item.shootSpeed = 12f;
			Item.shoot = ModContent.ProjectileType<Projectiles.TyphoonPro>();
			Item.knockBack = 3;
			Item.value = 33000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sea Dawn");
			// Tooltip.SetDefault("");
		}

	}
}
