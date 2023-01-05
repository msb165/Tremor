using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ThrowingCog:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 49;
			item.DamageType = DamageClass.Throwing;
			item.width = 30;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.consumable = true;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.shoot = ModContent.ProjectileType<Projectiles.ThrowingCog>();
			item.shootSpeed = 10f;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 7;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Throwing Cog");
			Tooltip.SetDefault("");
		}

	}
}
