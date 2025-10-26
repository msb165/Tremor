using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ButcherAxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 14;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 15;
			Item.useAnimation = 27;
			Item.axe = 9;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 6000;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Butcher Axe");
			// Tooltip.SetDefault("");
		}

	}
}
