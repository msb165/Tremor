using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CornJavelin:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 22;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.shoot = ModContent.ProjectileType<Projectiles.CornJavelinPro>();
			Item.shootSpeed = 22f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 7;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Corn Javelin");
			// Tooltip.SetDefault("");
		}

	}
}
