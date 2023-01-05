using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EssenseofJungle:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 14;
			item.height = 22;
			item.maxStack = 99;
			item.rare = 8;
			item.value = Item.buyPrice(0, 5, 0, 0);

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Essence of Jungle");
			Tooltip.SetDefault("'Plants fill you with determination.'");
		}

	}
}
