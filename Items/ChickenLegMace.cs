using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ChickenLegMace:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 22;
			Item.DamageType = DamageClass.Melee;
			Item.width = 54;
			Item.height = 54;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = 1;
			Item.knockBack = 12;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chicken Leg Mace");
			// Tooltip.SetDefault("");
		}

	}
}
