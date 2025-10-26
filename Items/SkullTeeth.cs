using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SkullTeeth:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 30;

			Item.maxStack = 99;
			Item.value = 8000;
			Item.rare = 6;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Skull Teeth");
			// Tooltip.SetDefault("'Hell yeah!'");
		}

	}
}
