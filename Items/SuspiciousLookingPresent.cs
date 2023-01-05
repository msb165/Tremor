using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SuspiciousLookingPresent:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 22;
			item.maxStack = 1;
			item.value = 10000;

			item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Suspicious Looking Present");
			Tooltip.SetDefault("Allows the Elf to move in");
		}

	}
}
