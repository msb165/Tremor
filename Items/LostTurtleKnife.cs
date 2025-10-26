using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LostTurtleKnife:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 177;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.LostTurtleKnifePro>();
			Item.shootSpeed = 22f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 11;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Lost Turtle Knife");
			// Tooltip.SetDefault("");
		}

	}
}
