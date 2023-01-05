using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ChickenLegMace:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 22;
			item.DamageType = DamageClass.Melee;
			item.width = 54;
			item.height = 54;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chicken Leg Mace");
			Tooltip.SetDefault("");
		}

	}
}
