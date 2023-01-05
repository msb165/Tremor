using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MoltenParts:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 40;
			item.height = 28;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Parts");
			Tooltip.SetDefault("");
		}

	}
}
