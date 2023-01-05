using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NastyJavelin:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 162;
			item.width = 14;
			item.DamageType = DamageClass.Throwing;
			item.height = 84;
			item.noUseGraphic = true;
			item.consumable = true;
			item.maxStack = 999;
			item.useTime = 22;
			item.shoot = ModContent.ProjectileType<Projectiles.NastyJavelinPro>();
			item.shootSpeed = 20f;
			item.useAnimation = 22;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nasty Javelin");
			Tooltip.SetDefault("");
		}

	}
}
