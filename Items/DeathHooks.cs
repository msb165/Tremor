using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DeathHooks:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 262;
			Item.width = 14;
			Item.DamageType = DamageClass.Melee;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.useTime = 16;
			Item.shoot = ModContent.ProjectileType<Projectiles.DeathHooksPro>();
			Item.shootSpeed = 20f;
			Item.useAnimation = 16;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Death Hooks");
			// Tooltip.SetDefault("");
		}

	}
}
