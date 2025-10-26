using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class CursedCloth:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 99;
			Item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Cloth");
			// Tooltip.SetDefault("");
		}
	}
}
