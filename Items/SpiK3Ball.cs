using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SpiK3Ball:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 38;
			item.DamageType = DamageClass.Throwing;
			item.width = 18;
			item.height = 18;
			item.maxStack = 999;
			item.useTime = 12;
			item.useAnimation = 12;
			item.shoot = ModContent.ProjectileType<Projectiles.SpiK3Ball>();
			item.shootSpeed = 7f;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 155;
			item.rare = 8;
			item.consumable = true;
			item.UseSound = SoundID.Item1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SpiK-3 Ball");
			Tooltip.SetDefault("");
		}

	}
}
