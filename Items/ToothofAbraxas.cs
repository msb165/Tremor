using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ToothofAbraxas:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 19000;
			Item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tooth of Abraxas");
			// Tooltip.SetDefault("");
		}

	}
}
