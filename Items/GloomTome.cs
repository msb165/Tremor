using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GloomTome:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 23;
			item.DamageType = DamageClass.Magic;
			item.width = 28;
			item.height = 30;
			item.useTime = 14;
			item.useAnimation = 14;
			item.shoot = ModContent.ProjectileType<Projectiles.GloomSphere>();
			item.shootSpeed = 16f;
			item.mana = 12;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 5025;
			item.rare = 3;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gloom Tome");
			Tooltip.SetDefault("");
		}

	}
}
