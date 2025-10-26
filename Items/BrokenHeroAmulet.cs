using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BrokenHeroAmulet:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;
			Item.value = 10000;
			Item.rare = 8;
			Item.defense = 3;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Broken Hero Amulet");
			// Tooltip.SetDefault("");
		}

	}
}
