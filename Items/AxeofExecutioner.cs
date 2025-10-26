using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class AxeofExecutioner:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.autoReuse = true;
			Item.useStyle = 1;

			Item.shootSpeed = 8f;
			Item.shoot = ModContent.ProjectileType<Projectiles.AxeofExecutionerPro>();
			Item.damage = 175;
			Item.width = 18;
			Item.height = 20;
			Item.UseSound = SoundID.Item1;
			Item.useAnimation = 14;
			Item.useTime = 17;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.value = 500000;
			Item.knockBack = 5f;
			Item.DamageType = DamageClass.Melee;
			Item.rare = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Axe of Executioner");
			// Tooltip.SetDefault("");
		}

	}
}
