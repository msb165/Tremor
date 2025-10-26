using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TreasureGlaive:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 290;
			Item.width = 18;
			Item.height = 66;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Throwing;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.TreasureGlaive>();
			Item.shootSpeed = 15f;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 1000000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Treasure Glaive");
			// Tooltip.SetDefault("");
		}

	}
}
