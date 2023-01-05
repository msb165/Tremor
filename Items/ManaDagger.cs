using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ManaDagger:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 14;
			item.height = 28;
			item.rare = 7;
			item.damage = 30;
			item.DamageType = DamageClass.Magic;
			item.mana = 12;

			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 270000;
			item.UseSound = SoundID.Item20;
			item.autoReuse = false;
			item.shoot = ModContent.ProjectileType<Projectiles.projManaDagger>();
			item.shootSpeed = 15f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mana Dagger");
			Tooltip.SetDefault("A magical returning dagger\n" +
"Gives mana after hitting an enemy and returning");
		}

	}
}
