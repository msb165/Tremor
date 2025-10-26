using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ConcentratedEther:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 15000;
			Item.rare = 9;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Concentrated Ether");
			// Tooltip.SetDefault("");
		}

	}
}
