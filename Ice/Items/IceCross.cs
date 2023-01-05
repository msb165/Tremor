using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class IceCross:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 21;
			item.width = 26;
			item.height = 24;
			item.DamageType = DamageClass.Magic;
			item.mana = 40;
			item.useTime = 35;
			item.shoot = ModContent.ProjectileType<Icoj>();
			item.shootSpeed = 0f;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.value = 1000;
			item.rare = 1;
			item.UseSound = SoundID.Item43;

			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Cross");
			Tooltip.SetDefault("Summons an giant stationary frozen boulder that damages enemies and explodes into icicles after some time");
		}

	}
}
