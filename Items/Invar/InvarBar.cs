using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Invar
{
	public class InvarBar:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = Item.sellPrice(silver: 1, copper: 25);
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Invar Bar");
			// Tooltip.SetDefault("Can be used to make Invar equipment at an anvil");
		}

		public override void AddRecipes()
		{

		}
	}
}
