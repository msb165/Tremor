using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RazorleavesTome:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 5;
			Item.DamageType = DamageClass.Magic;
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.shoot = 206;
			Item.shootSpeed = 11f;
			Item.mana = 6;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Razorleaves Tome");
			// Tooltip.SetDefault("");
		}

	}
}
