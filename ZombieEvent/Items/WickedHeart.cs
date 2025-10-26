using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class WickedHeart:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 1000;
			Item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Wicked Heart");
			// Tooltip.SetDefault("");
		}
	}
}
