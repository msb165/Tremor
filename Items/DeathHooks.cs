using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DeathHooks:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 262;
			item.width = 14;
			item.DamageType = DamageClass.Melee;
			item.height = 84;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.useTime = 16;
			item.shoot = ModContent.ProjectileType<Projectiles.DeathHooksPro>();
			item.shootSpeed = 20f;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Death Hooks");
			Tooltip.SetDefault("");
		}

	}
}
