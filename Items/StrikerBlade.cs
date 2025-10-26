using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StrikerBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 54;
			Item.DamageType = DamageClass.Melee;
			Item.width = 36;
			Item.height = 44;
			Item.useTime = 11;
			Item.useAnimation = 11;
			Item.useStyle = 1;
			Item.useTurn = true;
			Item.knockBack = 6f;
			Item.value = 90000;
			Item.rare = 7;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Striker Blade");
			// Tooltip.SetDefault("");
		}

	}
}
