using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class DreadLance:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 56;

			Item.width = 54;
			Item.height = 54;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<DreadLancePro>();
			Item.shootSpeed = 4f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 1000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dread Lance");
			// Tooltip.SetDefault("Inflicts cursed flames on enemies");
		}
	}
}
