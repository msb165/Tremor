using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DragonBreath:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 46;
			item.DamageType = DamageClass.Throwing;
			item.width = 18;
			item.height = 18;
			item.useTime = 14;
			item.useAnimation = 14;
			item.maxStack = 999;
			item.shoot = ModContent.ProjectileType<Projectiles.DragonBreathPro>();
			item.shootSpeed = 8f;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 155;
			item.rare = 5;
			item.consumable = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragon Breath");
			Tooltip.SetDefault("");
		}

	}
}
