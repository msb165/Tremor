using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class CursedInk:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Ink");
			// Tooltip.SetDefault("");
		}
	}
}
