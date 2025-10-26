using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MonsterTooth:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 15;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.MonsterToothPro>();
			Item.shootSpeed = 22f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 7;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Monster Tooth");
			// Tooltip.SetDefault("");
		}

	}
}
