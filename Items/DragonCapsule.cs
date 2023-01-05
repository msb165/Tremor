using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DragonCapsule:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 44;
			item.height = 44;

			item.value = 1500;
			item.maxStack = 999;
			item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragon Capsule");
			Tooltip.SetDefault("A capsule of great creature");
		}

	}
}
