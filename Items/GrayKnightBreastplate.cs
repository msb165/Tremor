using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class GrayKnightBreastplate:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.value = 10000;
			item.rare = 2;

			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gray Knight Breastplate");
			Tooltip.SetDefault("Can be colored with gems");
		}

	}
}
