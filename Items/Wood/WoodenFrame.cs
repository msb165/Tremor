using Terraria.ModLoader;

namespace Tremor.Items.Wood
{
	public class WoodenFrame:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 34;
			Item.value = 120000;
			Item.rare = 2;
			Item.defense = 3;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Wooden Frame");
			// Tooltip.SetDefault("");
		}

	}
}
