using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Crystal
{
	public class CrystalSpear:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(165);

			Item.damage = 49;
			Item.DamageType = DamageClass.Magic;
			Item.width = 26;

			Item.height = 30;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.shoot = ModContent.ProjectileType<Projectiles.CrSpear>();
			Item.shootSpeed = 11.5f;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.mana = 12;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crystal Spear");
			// Tooltip.SetDefault("Shoots sharp crystal spears");
		}

	}
}
