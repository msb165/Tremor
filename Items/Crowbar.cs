using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Crowbar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 14;
			Item.DamageType = DamageClass.Melee;
			Item.width = 56;
			Item.height = 56;
			Item.useTime = 25;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 12000;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crowbar");
			// Tooltip.SetDefault("'Actually it snaps in two'");
		}

	}
}
