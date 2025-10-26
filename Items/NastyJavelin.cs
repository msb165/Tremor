using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NastyJavelin:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 162;
			Item.width = 14;
			Item.DamageType = DamageClass.Throwing;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.consumable = true;
			Item.maxStack = 999;
			Item.useTime = 22;
			Item.shoot = ModContent.ProjectileType<Projectiles.NastyJavelinPro>();
			Item.shootSpeed = 20f;
			Item.useAnimation = 22;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nasty Javelin");
			// Tooltip.SetDefault("");
		}

	}
}
