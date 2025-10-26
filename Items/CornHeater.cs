using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CornHeater:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 58;
			Item.height = 26;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.shoot = ModContent.ProjectileType<Projectiles.PopcornAmmo>();
			Item.shootSpeed = 8f;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.useAmmo = ModContent.ItemType<PopcornAmmo>();
			Item.value = 60000;
			Item.rare = 9;
			Item.expert = true;
			Item.UseSound = SoundID.Item11;

			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Corn Heater");
			// Tooltip.SetDefault("Uses popcorn as ammo");
		}

	}
}
