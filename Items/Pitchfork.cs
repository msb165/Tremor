using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Pitchfork:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 22;
			Item.width = 14;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 25;
			Item.shoot = ModContent.ProjectileType<Projectiles.PitchforkPro>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 25;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 50000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Pitchfork");
			// Tooltip.SetDefault("");
		}

	}
}
