using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class GrayKnightBreastplate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.value = 10000;
			Item.rare = 2;

			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gray Knight Breastplate");
			// Tooltip.SetDefault("Can be colored with gems");
		}

	}
}
