using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ThrowingCog:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 49;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 30;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.ThrowingCog>();
			Item.shootSpeed = 10f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 7;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Throwing Cog");
			// Tooltip.SetDefault("");
		}

	}
}
