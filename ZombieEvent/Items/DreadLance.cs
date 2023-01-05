using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class DreadLance:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 56;

			item.width = 54;
			item.height = 54;
			item.noUseGraphic = true;
			item.DamageType = DamageClass.Melee;
			item.useTime = 30;
			item.shoot = ModContent.ProjectileType<DreadLancePro>();
			item.shootSpeed = 4f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dread Lance");
			Tooltip.SetDefault("Inflicts cursed flames on enemies");
		}
	}
}
