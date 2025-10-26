using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MoltenParts:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 40;
			Item.height = 28;
			Item.maxStack = 99;
			Item.value = 1000;
			Item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Molten Parts");
			// Tooltip.SetDefault("");
		}

	}
}
