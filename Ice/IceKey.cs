using Terraria.ModLoader;

namespace Tremor.Ice
{
	public class IceKey:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 999;
			Item.value = 100000;
			Item.rare = 3;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ice Key");
			// Tooltip.SetDefault("Opens the Frozen Chest once");
		}

	}
}
