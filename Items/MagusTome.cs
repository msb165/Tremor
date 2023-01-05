using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MagusTome:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 25;
			//item.melee = false;
			item.DamageType = DamageClass.Magic;
			item.width = 50;
			item.height = 55;
			item.useTime = 25;
			item.mana = 9;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.shoot = ModContent.ProjectileType<Projectiles.MagusBallF>();
			item.shootSpeed = 12f;
			item.knockBack = 4;
			item.value = 32000;
			item.rare = 4;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magus Tome");
			Tooltip.SetDefault("Shoots out a bolt that pierces enemies and explodes on contant with blocks");
		}

	}
}
