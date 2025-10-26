using Terraria.ModLoader;

namespace Tremor.Items.Cursed
{
	[AutoloadEquip(EquipType.Legs)]
	public class CursedKnightGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 18;
			Item.value = 30000;

			Item.rare = 9;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Knight Greaves");
			// Tooltip.SetDefault("'Great for impersonating devs!'");
		}

	}
}
