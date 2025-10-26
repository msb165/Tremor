using Terraria.ModLoader;

namespace Tremor.Items.Cursed
{
	[AutoloadEquip(EquipType.Body)]
	public class CursedKnightBreastplate:TremorModItem
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
			// DisplayName.SetDefault("Cursed Knight Breastplate");
			// Tooltip.SetDefault("'Great for impersonating devs!'");
		}

	}
}
